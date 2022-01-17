using System;
using System.Threading.Tasks;

namespace Car2Go.Data.Seeding
{

    public interface ISeeder
    {
        Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider);
    }
}
