using System.Collections.Generic;

namespace Car2Go.Web.ViewModels.Orders
{
    public class OrdersDetailsViewModel
    {
        public IEnumerable<OrderDetailsInputModel> Cars { get; set; }
    }
}
