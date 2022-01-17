using System;
using Car2Go.Data.Models.Enums;
using Car2Go.Web.ViewModels.Cars;

namespace Car2Go.Web.ViewModels.Orders
{
    public class OrderDetailsInputModel : CarDetailInputModel
    {
        public string CarModel { get; set; }

        public GearType CarGearType { get; set; }

        public string Email { get; set; }

        public decimal Price { get; set; }

        public DateTime RentStart { get; set; }

        public DateTime RentEnd { get; set; }

        public OrderStatus Status { get; set; }

        public string PickUpLocation { get; set; }

        public string ReturnLocation { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }
    }
}
