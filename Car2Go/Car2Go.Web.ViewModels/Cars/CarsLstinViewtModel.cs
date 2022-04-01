using Car2Go.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car2Go.Web.ViewModels.Cars
{
    public class CarsLstinViewtModel : PagingViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
    }
}
