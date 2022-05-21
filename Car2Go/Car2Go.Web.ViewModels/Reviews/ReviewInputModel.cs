namespace Car2Go.Web.ViewModels.Reviews
{
  public class ReviewInputModel
    {
        public int CarId { get; set; }
        public string ApplicationUserId { get; set; }
        public int Rating { get; set; }

        public string Comment { get; set; }
    }
}
