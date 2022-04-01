using System;
using System.ComponentModel.DataAnnotations;
using Car2Go.Data.Common.Models;
using Car2Go.Data.Models.Enums;

namespace Car2Go.Data.Models
{
    public class Order : BaseDeletableModel<string>
    {
        public Order()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedOn = DateTime.UtcNow;
        }

        [Required]
        public int CarId { get; set; }

        public virtual Car Car { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime RentStart { get; set; }

        [Required]
        public DateTime RentEnd { get; set; }

        [Required]
        public OrderStatus Status { get; set; }

        [Required]
        public int PickUpLocationId { get; set; }

        public virtual Location PickUpLocation { get; set; }

        [Required]
        public int ReturnLocationId { get; set; }

        public virtual Location ReturnLocation { get; set; }
    }
}
