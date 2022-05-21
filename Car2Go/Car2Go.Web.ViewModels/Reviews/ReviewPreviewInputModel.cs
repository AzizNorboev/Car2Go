using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Car2Go.Web.ViewModels.Reviews
{
    public class ReviewPreviewInputModel
    {
        [Required]
        public int CarId { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Please input between 1 and 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Please also leave a comment")]
        [MinLength(16, ErrorMessage = "Please also leave a comment")]
        public string Comment { get; set; }
    }
}
