using Car2Go.Data.Common.Repositories;
using Car2Go.Data.Models;
using Car2Go.Services.Data;
using Car2Go.Web.ViewModels.Reviews;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Car2Go.Web.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly IReviewsService reviewsService;
        private readonly IDeletableEntityRepository<Review> dataRepository;

        public ReviewsController(IReviewsService reviewsService, IDeletableEntityRepository<Review> dataRepository)
        {
            this.reviewsService = reviewsService;
            this.dataRepository = dataRepository;
        }

        public IActionResult Index()
        {
            var viewModel = new AllReviewsInputViewModel
            {
                Reviews = dataRepository.All().Include(c => c.Car)
                                              .Include(u => u.User)
            };
            return this.View(viewModel);
        }

        [Authorize]
        public IActionResult Details(int id)
        {
            var viewModel = new ReviewViewModel
            {
                Reviews = this.reviewsService.GetReviewById(id),
            };
            if(viewModel == null)
            {
                Console.WriteLine("afsfas");
            }
            return this.View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Preview(ReviewPreviewInputModel inputModel)
        {
            return this.View(inputModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(ReviewInputModel inputModel)
        {

            if (!this.ModelState.IsValid)
            {
                return View("Error");
            }

            var result = await reviewsService.CreateReview(inputModel.CarId, inputModel.ApplicationUserId, inputModel.Rating, inputModel.Comment);

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
