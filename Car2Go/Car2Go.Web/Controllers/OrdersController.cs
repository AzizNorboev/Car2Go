using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Car2Go.Data.Models;
using Car2Go.Services.Data;
using Car2Go.Web.ViewModels.Orders;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Car2Go.Data.Common.Repositories;

namespace Car2Go.Web.Controllers
{
    public class OrdersController : BaseController
    {
        private readonly IOrdersService ordersService;
        private readonly IDeletableEntityRepository<Order> dataRepository;
        private readonly ICarsService carsService;
        private readonly UserManager<ApplicationUser> userManager;

        public OrdersController(
            ICarsService carsService,
            IDeletableEntityRepository<Order> dataRepository,
            IOrdersService ordersService,
            UserManager<ApplicationUser> userManager)
        {
            this.carsService = carsService;
            this.dataRepository = dataRepository;
            this.ordersService = ordersService;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult MyOrders()
        {
            var viewModel = new AllOrderInputViewModel
            {
                Orders = dataRepository.All().Include(c => c.Car)
                                             .Include(u => u.User)
                                             .Include(l => l.PickUpLocation)
                                             .Include(l=>l.ReturnLocation)
            };

            return this.View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Preview(OrderPreviewInputModel inputModel)
        {
            return this.View(inputModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Order(OrderInputViewModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.RedirectToAction("Index", "Home");
            }

            var result = await this.ordersService.MakeOrder(this.User.Identity.Name, inputModel.Id, inputModel.PickUpPlace, inputModel.ReturnPlace, inputModel.Price, inputModel.PickUp, inputModel.Return);
            var carModel = this.carsService.GetCarModelById(id: inputModel.Id);
            var days = (inputModel.Return - inputModel.PickUp).Days;

            return this.RedirectToAction(nameof(this.MyOrders));
        }

        [Authorize]
        public IActionResult Details(string id)
        {
            var viewModel = new OrdersDetailsViewModel
            {
                Cars = this.ordersService.GetOrderById(id),
            };

            return this.View(viewModel);
        }
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var order = await dataRepository.All().FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return this.NotFound();
            }

            return View(order);
        }

        [Authorize]
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await ordersService.Delete(id);

            return this.RedirectToAction(nameof(this.MyOrders));
        }
    }
}
