using Car2Go.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Car2Go.Data.Models
{
    public class Dealer : BaseDeletableModel<int>
    {

        [Required]
        [MaxLength(1000)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        public string UserId { get; set; }

        public IEnumerable<Car> Cars { get; set; } = new List<Car>();
    }
}
