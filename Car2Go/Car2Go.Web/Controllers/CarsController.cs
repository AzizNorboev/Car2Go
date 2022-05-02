using System.Linq;
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

        public IActionResult All(string searchTerm, string culture, int id = 1)
        {
            if (!string.IsNullOrEmpty(searchTerm))
            {          
                searchTerm = char.ToUpper(searchTerm[0]) + searchTerm.Substring(1);
            }
            const int ItemsPerPage = 6;
            CarsLstinViewtModel viewModel;
            if (!string.IsNullOrEmpty(searchTerm)) 
            {
                viewModel = new CarsLstinViewtModel
              {
                   ItemsPerPage = ItemsPerPage,
                   PageNumber = id,
                   CarsCount = this.carsService.GetCount(),
                   Cars = this.carsService.GetAll(id, ItemsPerPage).Where(a => a.Model.Contains(searchTerm))
                };
            }
            else
            {
                viewModel = new CarsLstinViewtModel
                {
                    ItemsPerPage = ItemsPerPage,
                    PageNumber = id,
                    CarsCount = this.carsService.GetCount(),
                    Cars = this.carsService.GetAll(id, ItemsPerPage)
                };
            }

            return this.View(viewModel);
        }

       [HttpGet]
        public IActionResult Available(SearchCarsViewModel model, string searchTerm)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                return this.Redirect("/Identity/Account/Login");
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                searchTerm = char.ToUpper(searchTerm[0]) + searchTerm.Substring(1);
            }
            var cars = this.carsService.GetAvailableCars(model.Pickup, model.Return, model.PickupPlace).ToList();
            if (!string.IsNullOrEmpty(searchTerm))
            { 
             cars = this.carsService.GetAvailableCars(model.Pickup, model.Return, model.PickupPlace)
                    .Where(c => c.Model.Contains(searchTerm)).ToList();
            }
            var viewModel = new AvailableCarsViewModel
            {
                Cars = cars,
                Start = model.Pickup,
                End = model.Return,
                Days = (model.Return.Date - model.Pickup.Date).TotalDays,

                PickUpPlace = model.PickupPlace,
                ReturnPlace = model.ReturnPlace,
            };

            return this.View(viewModel);
        }

        public async Task<IActionResult> DetailsAsync(int id)
        {
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
