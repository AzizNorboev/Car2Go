using Car2Go.Web.ViewModels.Reviews;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Car2Go.Services.Data
{
    public interface IReviewsService
    {
        Task<bool> CreateReview(int carId, string userId, int rating, string comment);

        IEnumerable<ReviewInputModel> GetReviewById(int id);
    }
}
