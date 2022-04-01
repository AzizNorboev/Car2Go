using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Car2Go.Data.Common.Models;
using Car2Go.Data.Models.Enums;

namespace Car2Go.Data.Models
{
    public class Car : BaseDeletableModel<int>
    {
        public Car()
        {
            this.RentDays = new HashSet<CarRentDays>();
            this.InUse = true;
            this.CreatedOn = DateTime.UtcNow;
        }

        //TODO: Add color property
        public bool InUse { get; set; }

        [Required]
        [MinLength(5)]
        public string Model { get; set; }

        [Required]
        [MinLength(15)]
        public string Description { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int Speed { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public GearType GearType { get; set; }

        [Required]
        public decimal PricePerDay { get; set; }

        public virtual ICollection<CarRentDays> RentDays { get; set; }
    }
}
