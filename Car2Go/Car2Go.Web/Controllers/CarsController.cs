using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Car2Go.Services.Data;
using Car2Go.Web.ViewModels.Cars;
using Car2Go.Web.ViewModels.Home;
using Car2Go.Data.Common.Repositories;
using Car2Go.Data.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Car2Go.Web.Controllers
{
    public class CarsController : BaseController
    {
        private readonly ICarsService carsService;
        private readonly IDeletableEntityRepository<Car> dataRepository;
        private readonly IDealerService delearService;
        public CarsController(ICarsService carsService, IDeletableEntityRepository<Car> dataRepository, IDealerService delearService)
        {
            this.carsService = carsService;
            this.dataRepository = dataRepository;
            this.delearService = delearService;
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

            if(model.Pickup < DateTime.Today || model.Pickup > model.Return)
            {
                return View("Error");
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

        [Authorize]
        public IActionResult Mine()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var myCars = carsService.ByUser(userId);

            return View(myCars);
        }

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        // POST: Administration/Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InUse,Model,Description,Year,Speed,Image,GearType,PricePerDay, DealerId, IsDeleted,DeletedOn,Id,CreatedOn,ModifiedOn")] Car car)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            car.DealerId = delearService.IdByUser(userId);
            if (this.ModelState.IsValid)
            {
                await this.dataRepository.AddAsync(car);
                await this.dataRepository.SaveChangesAsync();
                return this.RedirectToAction(nameof(this.Mine));
            }
            await this.dataRepository.AddAsync(car);
            await this.dataRepository.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Mine));
        }
        [Authorize]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var car = this.dataRepository.All().FirstOrDefault(x => x.Id == id);
            if (car == null)
            {
                return this.NotFound();
            }

            return this.View(car);
        }

        // POST: Administration/Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InUse,Model,Description,Year,Speed,Image,GearType,PricePerDay, DealerId, IsDeleted,DeletedOn,Id,CreatedOn,ModifiedOn")] Car car)
        {
            if (id != car.Id)
            {
                return this.NotFound();
            }
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            car.DealerId = delearService.IdByUser(userId);
            if (this.ModelState.IsValid)
            {
                try
                {
                    this.dataRepository.Update(car);
                    await this.dataRepository.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!this.CarExists(car.Id))
                    {
                        return this.NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return this.RedirectToAction(nameof(this.Mine));
            }

            return this.View(car);
        }

        public async Task<IActionResult> Delete(int? id)
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

        // POST: Administration/Cars/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var car = this.dataRepository.All().FirstOrDefault(x => x.Id == id);
            this.dataRepository.Delete(car);
            await this.dataRepository.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Mine));
        }
        private bool CarExists(int id)
        {
            return this.dataRepository.All().Any(e => e.Id == id);
        }
    }
}
