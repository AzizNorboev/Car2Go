using Car2Go.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car2Go.Web.ViewModels.Reviews
{
    public class AllReviewsInputViewModel
    {
        public IEnumerable<Review> Reviews { get; set; }
    }
}
