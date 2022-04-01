﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Car2Go.Services.Data;
using Car2Go.Web.ViewModels.Cars;
using Car2Go.Web.ViewModels.Home;
using Car2Go.Data.Common.Repositories;
using Car2Go.Data.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Car2Go.Web.Controllers
{
    public class CarsController : BaseController
    {
        private readonly ICarsService carsService;
        private readonly IDeletableEntityRepository<Car> dataRepository;
        public CarsController(ICarsService carsService, IDeletableEntityRepository<Car> dataRepository)
        {
            this.carsService = carsService;
            this.dataRepository = dataRepository;
        }

        public IActionResult All(int id = 1)
        {
            const int ItemsPerPage = 6;
            var viewModel = new CarsLstinViewtModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                CarsCount = this.carsService.GetCount(),
                Cars = this.carsService.GetAll(id, ItemsPerPage),
            };

            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult Available(SearchCarsViewModel model)
        {
            if (!this.User.Identity.IsAuthenticated)
        {
                return this.Redirect("/Identity/Account/Login");
            }

            if (!this.ModelState.IsValid)
               {
               return this.RedirectToAction("Index", "Home");
            }

            var cars = this.carsService.GetAvailableCars(model.Pickup, model.Return, model.PickupPlace).ToList();

            var viewModel = new AvailableCarsViewModel
            {
                Cars = cars,
                Start = model.Pickup,
                End = model.Return,
                Days = (model.Return.Date - model.Pickup.Date).TotalDays,

                PickUpPlace = model.PickupPlace,
                ReturnPlace = model.PickupPlace,
            };

            return this.View(viewModel);
        }

        public async Task<IActionResult> DetailsAsync(int id)
        {
            //const int ItemsPerPage = 1;
            //var viewModel = new CarsLstinViewtModel
            //{
            //    Cars = this.carsService.GetAll(id, ItemsPerPage),
            //};
            if (id == null)
            {
                return this.NotFound();
            }

            var car = await this.dataRepository.All()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return this.NotFound();
            }

            return this.View(car);
        }
    }
}
