using System;
using System.ComponentModel.DataAnnotations;
using Car2Go.Data.Common.Models;

namespace Car2Go.Data.Models
{
    public class CarRentDays : BaseDeletableModel<int>
    {
        [Required]
        public int CarId { get; set; }

        public virtual Car Car { get; set; }

        [Required]
        public DateTime RentDate { get; set; }
    }
}
