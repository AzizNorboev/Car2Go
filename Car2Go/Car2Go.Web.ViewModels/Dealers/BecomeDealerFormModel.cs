using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Car2Go.Web.ViewModels.Dealers
{
    public class BecomeDealerFormModel
    {
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 7)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
