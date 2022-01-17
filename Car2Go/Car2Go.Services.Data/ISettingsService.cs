using System.Collections.Generic;

namespace Car2Go.Services.Data
{

    public interface ISettingsService
    {
        int GetCount();

        IEnumerable<T> GetAll<T>();
    }
}
