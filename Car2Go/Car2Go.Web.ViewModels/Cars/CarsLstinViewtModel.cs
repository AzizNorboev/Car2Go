using System;
using System.Collections.Generic;
using System.Text;

namespace Car2Go.Web.ViewModels.Cars
{
    public class CarsLstinViewtModel : PagingViewModel
    {
        public IEnumerable<CarDetailInputModel> Cars { get; set; }
    }
}
