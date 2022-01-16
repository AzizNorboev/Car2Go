using System;
using System.ComponentModel.DataAnnotations;
using Car2Go.Data.Common.Models;

namespace Car2Go.Data.Models
{
    public class Review : BaseDeletableModel<int>
    {
        [Required]
        public int CarId { get; set; }

        public virtual Car Car { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        [Required]
        [MinLength(16)]
        public string Comment { get; set; }
    }
}
