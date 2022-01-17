using System.Collections.Generic;
using Car2Go.Web.ViewModels.Locations;

namespace Car2Go.Services.Data
{
    public interface ILocationsService
    {
        IEnumerable<LocationInputModel> GetAllLocation(string name);

        ICollection<string> GetAllLocationNames();

        int GetIdByName(string name);
    }
}
