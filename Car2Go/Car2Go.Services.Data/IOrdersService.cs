using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Car2Go.Web.ViewModels.Orders;

namespace Car2Go.Services.Data
{
    public interface IOrdersService
    {
        Task<bool> MakeOrder(string email, int carId, string startLocation, string returnLocation, decimal price, DateTime startRent, DateTime endRent);

        bool UserFinishedOrders(string name);

        IEnumerable<MyOrdersViewModel> All();

        IEnumerable<OrderDetailsInputModel> GetOrderById(string id);
    }
}
