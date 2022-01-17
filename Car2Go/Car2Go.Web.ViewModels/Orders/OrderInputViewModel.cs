using System;

namespace Car2Go.Web.ViewModels.Orders
{
    public class OrderInputViewModel
    {
        public int Id { get; set; }

        public DateTime PickUp { get; set; }

        public DateTime Return { get; set; }

        public decimal Price { get; set; }

        public string PickUpPlace { get; set; }

        public string ReturnPlace { get; set; }

        public string? DiscountCode { get; set; }
    }
}
