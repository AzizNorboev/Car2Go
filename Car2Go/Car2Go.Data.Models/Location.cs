using System;
using System.ComponentModel.DataAnnotations;
using Car2Go.Data.Common.Models;

namespace Car2Go.Data.Models
{
    public class Location : BaseDeletableModel<int>
    {
        public Location()
        {
            this.CreatedOn = DateTime.UtcNow;
        }

        [Required]
        public string Name { get; set; }
    }
}
