using Car2Go.Data.Models;
using System.Collections.Generic;

namespace Car2Go.Web.ViewModels.Orders
{
    public class AllOrderInputViewModel
    {
       public IEnumerable<Order> Orders { get; set; }
    }
}
