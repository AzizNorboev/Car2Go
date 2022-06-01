
using System.Threading.Tasks;

namespace Car2Go.Services.EmailSender
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
        Task SendEmailAsync(Message message);
    }
}
