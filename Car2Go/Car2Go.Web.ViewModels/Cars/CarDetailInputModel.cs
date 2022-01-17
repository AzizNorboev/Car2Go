using System.Collections.Generic;
using Car2Go.Data.Models;
using Car2Go.Data.Models.Enums;
using Car2Go.Web.ViewModels.Reviews;

namespace Car2Go.Web.ViewModels.Cars
{
    public class CarDetailInputModel
    {
        public CarDetailInputModel()
        {
            this.Reviews = new HashSet<ReviewInputModel>();
        }

        public int Id { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        public int Speed { get; set; }

        public int Year { get; set; }

        public string Image { get; set; }

        public GearType GearType { get; set; }

        public decimal PricePerDay { get; set; }

        public int LocationId { get; set; }

        public Location Location { get; set; }
    }
}
