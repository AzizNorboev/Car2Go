using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Car2Go.Web.ViewModels.Cars;
using Car2Go.Web.ViewModels.Locations;

namespace Car2Go.Services.Data
{
    public interface ICarsService
    {
        int GetCount();

        IEnumerable<CarDetailInputModel> GetAll(int page, int itemsPerRege = 6);

        IEnumerable<ListCarInputModel> GetAvailableCars(DateTime start, DateTime end, string location);

        IEnumerable<CarDetailInputModel> GetCarModelById(int id);
    }
}
