using System.Collections.Generic;
using System.Linq;
using Car2Go.Data.Common.Repositories;
using Car2Go.Data.Models;
using Car2Go.Services.Mapping;

namespace Car2Go.Services.Data
{
    public class SettingsService : ISettingsService
    {
        private readonly IDeletableEntityRepository<Setting> settingsRepository;

        public SettingsService(IDeletableEntityRepository<Setting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.settingsRepository.All().To<T>().ToList();
        }

        public int GetCount()
        {
            return this.settingsRepository.AllAsNoTracking().Count();
        }
    }
}
