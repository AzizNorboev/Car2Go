using Car2Go.Data.Common.Repositories;
using Car2Go.Data.Models;
using Car2Go.Services.Data;
using Car2Go.Web.ViewModels.Orders;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Car2Go.Web.Areas.Administration.Controllers
{
    public class OrdersController : AdministrationController
    {
        private readonly IDeletableEntityRepository<Order> dataRepository;
        private readonly IOrdersService ordersService;
        private readonly ICarsService carsService;
        private readonly UserManager<ApplicationUser> userManager;
        private string UserId = string.Empty;

        public OrdersController(
            ICarsService carsService,
            IDeletableEntityRepository<Order> dataRepository,
            IOrdersService ordersService,
            UserManager<ApplicationUser> userManager,
            IHttpContextAccessor httpContextAccessor)
        {
            this.carsService = carsService;
            this.dataRepository = dataRepository;
            this.ordersService = ordersService;
            this.userManager = userManager;
            UserId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        // GET: Administration/Orders
        public async Task<IActionResult> Index()
        {
            var viewModel = new AllOrderInputViewModel
            {
                Orders = dataRepository.All().Include(c => c.Car)
                                          .Include(u => u.User)
                                          .Include(l => l.PickUpLocation)
                                          .Include(l => l.ReturnLocation)
            };
            return  View(viewModel);
        }

        // GET: Administration/Cars/Details/5
        public async Task<IActionResult> Details(string id)
        {
            var viewModel = new OrdersDetailsViewModel
            {
                Cars = ordersService.GetOrderById(id),
            };

            return View(viewModel);
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


        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            try
            {
                await ordersService.Delete(id);
            }
            catch (Exception ex)
            {
                return View("Error");
            }

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
