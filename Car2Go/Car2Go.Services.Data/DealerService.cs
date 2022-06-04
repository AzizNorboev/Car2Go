using Car2Go.Data.Common.Repositories;
using Car2Go.Data.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Car2Go.Services.Data
{
    public class DealerService : IDealerService
    {
        private readonly IDeletableEntityRepository<Dealer> dealerRepository;

        public DealerService(IDeletableEntityRepository<Dealer> dealerRepository)
            => this.dealerRepository = dealerRepository;

        public bool IsDealer(string userId)
            => this.dealerRepository
                .AllAsNoTracking()
                .Any(d => d.UserId == userId);

        public int IdByUser(string userId)
        {
            return dealerRepository
                .AllAsNoTracking()
                .Where(d => d.UserId == userId)
                .Select(d => d.Id)
                .FirstOrDefault();
        }

        public async Task<bool> BecomeDealer(string name, string phoneNumber, string userId)
        {
            var dealer = new Dealer()
            {
                Name = name,
                PhoneNumber = phoneNumber,
                UserId = userId
            };
            await dealerRepository.AddAsync(dealer);
            await dealerRepository.SaveChangesAsync();

            return true;
        }
    }
}
