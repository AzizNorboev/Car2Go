using System;
using System.Collections.Generic;
using System.Linq;
using Car2Go.Data.Common.Repositories;
using Car2Go.Data.Models;
using Car2Go.Web.ViewModels.Cars;
using Microsoft.EntityFrameworkCore;

namespace Car2Go.Services.Data
{

    public class CarsService : ICarsService
    {
        private readonly IDeletableEntityRepository<Car> carsRepository;
        private readonly IDeletableEntityRepository<Order> dataRepository;

        public CarsService(IDeletableEntityRepository<Car> carsRepository, IOrdersService ordersService, IDeletableEntityRepository<Order> dataRepository)
        {
            this.carsRepository = carsRepository;
            this.dataRepository = dataRepository;
        }

        public IEnumerable<Car> GetAll(int page, int itemsPerRege = 6)
        {
            var cars = this.carsRepository.AllAsNoTracking()
                  .OrderBy(x => x.Id)
                  .Skip((page - 1) * itemsPerRege)
                  .Take(itemsPerRege)
                  .Select(x => new Car
                  {
                      Id = x.Id,
                      Description = x.Description,
                      Model = x.Model,
                      PricePerDay = x.PricePerDay,
                      Image = x.Image,
                      Year = x.Year,
                      GearType = x.GearType,
                      Speed = x.Speed
                  }).ToList();

            return cars;
        }

        public int GetCount()
        {
            return this.carsRepository.All().Count();
        }

        public IEnumerable<ListCarInputModel> GetAvailableCars(DateTime start, DateTime end, string location)
        {
            var dates = new List<DateTime>();
            for (var dt = start; dt <= end; dt = dt.AddDays(1))
            {
                dates.Add(dt);
            }

                var cars = this.carsRepository.AllAsNoTracking().
                  Where(x => x.RentDays.Any(d => dates.Contains(d.RentDate)) == false).
                  Select(x => new ListCarInputModel
                  {
                      Id = x.Id,
                      Image = x.Image,
                      Description = x.Description,
                      GearType = x.GearType,
                      PricePerDay = x.PricePerDay,
                      Model = x.Model,
                      Year = x.Year,
                      Days = dates.Count(),
                      StartRent = start,
                      End = end,
                  }).
                 ToList();


            //Remove cars that orders contain
            var Orders = dataRepository.All().Include(c => c.Car)
                                          .Include(u => u.User)
                                          .Include(l => l.PickUpLocation)
                                          .Include(l => l.ReturnLocation);

            List<ListCarInputModel> CarsToBeRemoved = new List<ListCarInputModel>();
            foreach (var c in cars)
            {
                foreach(var r in Orders)
                {
                    if(r.RentEnd.CompareTo(DateTime.Today) <= 0)
                    {
                        r.Status = Car2Go.Data.Models.Enums.OrderStatus.Finished;
                    }
                    if (r.CarId == c.Id && r.Status != Car2Go.Data.Models.Enums.OrderStatus.Finished)
                    {
                        Console.WriteLine(r.CarId + " " + c.Id);
                        CarsToBeRemoved.Add(c);
                    }
                }
            }
            foreach(var c in CarsToBeRemoved)
            {
                if (cars.Contains(c))
                {
                    cars.Remove(c);
                }
            }


            return cars;
        }

        public IEnumerable<CarDetailInputModel> GetCarModelById(int id)
        {
            var cars = this.carsRepository.AllAsNoTracking()
                .OrderBy(x => x.Id)
                .Select(x => new CarDetailInputModel
                {
                    Id = x.Id,
                    Description = x.Description,
                    Model = x.Model,
                    Image = x.Image,
                    GearType = x.GearType,
                }).ToList();

            return cars;
        }

        public IEnumerable<Car> ByUser(string userId)
        {
            var cars = this.carsRepository.AllAsNoTracking()
                 .OrderBy(x => x.Id)
                 .Select(x => new Car
                 {
                     Id = x.Id,
                     Description = x.Description,
                     Model = x.Model,
                     PricePerDay = x.PricePerDay,
                     Image = x.Image,
                     Year = x.Year,
                     GearType = x.GearType,
                     Speed = x.Speed,
                     Dealer = x.Dealer
                 }).ToList();

            return cars.Where(c => c.Dealer.UserId == userId);
        }
    }
}
