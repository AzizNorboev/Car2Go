using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Car2Go.Services.Data;
using Car2Go.Web.ViewModels;
using Car2Go.Web.ViewModels.Home;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace Car2Go.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILocationsService locationsService;
        private readonly IOrdersService ordersService;

        public HomeController(ILocationsService locationsService, IOrdersService ordersService)
        {
            this.locationsService = locationsService;
            this.ordersService = ordersService;
        }

        public IActionResult Index(string culture)
        {
            var locationsList = locationsService.GetAllLocationNames();

            ViewData["FinishedOrders"] = ordersService.UserFinishedOrders(User.Identity.Name);
            return View(new SearchCarsViewModel { Locations = locationsList });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
