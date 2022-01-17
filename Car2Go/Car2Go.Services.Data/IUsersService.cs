using Car2Go.Data.Models;

namespace Car2Go.Services
{
    public interface IUsersService
    {
        string GetUserIdByEmail(string email);

        ApplicationUser GetUserByEmail(string email);
    }
}
