using Car2Go.Data.Common.Repositories;
using Car2Go.Data.Models;
using Car2Go.Web.ViewModels.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car2Go.Services.Data
{
    public class ReviewsService : IReviewsService
    {
        private readonly IDeletableEntityRepository<Review> reviewRepository;
        private readonly IRepository<Order> orderRepository;

        public ReviewsService(IDeletableEntityRepository<Review> reviewRepository, IRepository<Order> orderRepository)
        {
            this.reviewRepository = reviewRepository;
            this.orderRepository = orderRepository;
        }
        public async Task<bool> CreateReview(int carId, string userId, int rating, string comment)
        {
            //var order = orderRepository.All().Where(o => o.Id == orderId);
            //int carId = default;
            //string userId = string.Empty;
            //foreach (var item in order)
            //{
            //    item.CarId = carId;
            //    item.User.Id = userId;
            //}

            var review = new Review
            {
                CarId = carId,
                ApplicationUserId = userId,
                Rating = rating,
                Comment = comment
            };

            await reviewRepository.AddAsync(review);
            await reviewRepository.SaveChangesAsync();

            return true;
        }

        public IEnumerable<ReviewInputModel> GetReviewById(int id)
        {
            var reviews = this.reviewRepository.AllAsNoTracking()
               .OrderBy(x => x.User.Email).OrderByDescending(x => x.CreatedOn).
               Select(x => new ReviewInputModel
               {
                  CarId = x.CarId,
                  ApplicationUserId = x.ApplicationUserId,
                  Rating = x.Rating,
                  Comment = x.Comment
               }).Where(r => r.CarId == id)
               .ToList();

            return reviews;
        }
    }
}
