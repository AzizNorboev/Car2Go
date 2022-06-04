using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car2Go.Services.Data
{
    public interface IDealerService
    {
        Task<bool> BecomeDealer(string name, string phoneNumber, string userId);
        public bool IsDealer(string userId);

        public int IdByUser(string userId);
    }
}
