using System.Collections.Generic;

namespace Car2Go.Web.ViewModels.Orders
{
    public class AllOrderInputViewModel
    {
       public IEnumerable<MyOrdersViewModel> Orders { get; set; }
    }
}
