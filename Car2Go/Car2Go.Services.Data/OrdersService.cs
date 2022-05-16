using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car2Go.Data.Common.Repositories;
using Car2Go.Data.Models;
using Car2Go.Web.ViewModels.Orders;
using Microsoft.EntityFrameworkCore;

namespace Car2Go.Services.Data
{
    public class OrdersService : IOrdersService
    {
        private readonly IDeletableEntityRepository<Order> ordersRepository;
        private readonly IUsersService usersService;
        private readonly ILocationsService locationsService;

        public OrdersService(IDeletableEntityRepository<Order> ordersRepository, IUsersService usersService, ILocationsService locationsService)
        {
            this.ordersRepository = ordersRepository;
            this.usersService = usersService;
            this.locationsService = locationsService;
        }

        public IEnumerable<MyOrdersViewModel> All()
        {
            var orders = this.ordersRepository.AllAsNoTracking().OrderBy(x => x.User.Email).OrderByDescending(x => x.CreatedOn).Select(x => new MyOrdersViewModel
            {
                Id = x.Id,
                CarModel = x.Car.Model,
                PickUpLocation = x.PickUpLocation.Name,
                ReturnLocation = x.ReturnLocation.Name,
                Price = x.Price,
                RentStart = x.RentStart,
                RentEnd = x.RentEnd,
                Status = x.Status,
            }).ToList();

            return orders;
        }

        public async Task<bool> Delete(string id)
        {
            var order = ordersRepository.All().FirstOrDefault(x => x.Id == id);
            if(order.RentStart <= DateTime.Today && DateTime.Today <= order.RentEnd)
            {
                throw new InvalidOperationException("Cannot delete a reservation after car already has been rented");
            }
            //if (order.RentEnd <= DateTime.Today)
            //{
            //    throw new InvalidOperationException("Cannot delete a reservation after car already has been rented");
            //}
            ordersRepository.Delete(order);
            await ordersRepository.SaveChangesAsync();
            return true;
        }


        public IEnumerable<OrderDetailsInputModel> GetOrderById(string userName)
        {
            var orders = this.ordersRepository.AllAsNoTracking()
                .OrderBy(x => x.User.Email).OrderByDescending(x => x.CreatedOn).
                Select(x => new OrderDetailsInputModel
            {
                    Id = x.CarId,
                    Email = x.User.Email,
                    PickUpLocation = x.PickUpLocation.Name,
                    ReturnLocation = x.ReturnLocation.Name,
                    RentStart = x.RentStart,
                    RentEnd = x.RentEnd,
                    CarModel = x.Car.Model,
                    Image = x.Car.Image,
                    Description = x.Car.Description,
                    CarGearType = x.Car.GearType,
                    Year = x.Car.Year,
                    Price = x.Price,
            }).Where(o => o.Email == userName)
                .ToList();

            return orders;
        }

        public async Task<bool> MakeOrder(string email, int carId, string startLocation, string returnLocation, decimal price, DateTime startRent, DateTime endRent)
       {
           var userId = this.usersService.GetUserIdByEmail(email);

           var pickupLocationId = this.locationsService.GetIdByName(startLocation);
           var returnLocationId = this.locationsService.GetIdByName(returnLocation);
           if (userId is null)
            {
                return false;
            }

           var order = new Order
           {
              ApplicationUserId = userId,
              CarId = carId,
              RentEnd = endRent,
              RentStart = startRent,
              Price = price,
              PickUpLocationId = pickupLocationId,
              ReturnLocationId = returnLocationId,
              Status = Car2Go.Data.Models.Enums.OrderStatus.Active,
           };

           await this.ordersRepository.AddAsync(order);
           await this.ordersRepository.SaveChangesAsync();

           return true;
        }

        public bool UserFinishedOrders(string name)
        {
            return this.ordersRepository.AllAsNoTracking().
                   Any(x => x.User.UserName == name);
        }
    }
}
