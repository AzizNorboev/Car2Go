using Car2Go.Data.Common.Repositories;
using Car2Go.Data.Models;
using Car2Go.Services.Data;
using Car2Go.Web.ViewModels.Dealers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Car2Go.Web.Controllers
{
    public class DealersController : Controller
    {
        private readonly IDeletableEntityRepository<Dealer> dataRepository;
        private readonly IDealerService delearService;

        public DealersController(IDeletableEntityRepository<Dealer> dataRepository, IDealerService delearService)
        {
            this.dataRepository = dataRepository;
            this.delearService = delearService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Become() => View();

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Become(BecomeDealerFormModel dealer)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userIdAlreadyDealer = this.dataRepository
                .AllAsNoTracking()
                .Any(d => d.UserId == userId);
            if (userIdAlreadyDealer)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return View(dealer);
            }
            await delearService.BecomeDealer(dealer.Name, dealer.PhoneNumber, userId);

            return RedirectToAction(nameof(CarsController.Mine), "Cars");
        }
    }
}
