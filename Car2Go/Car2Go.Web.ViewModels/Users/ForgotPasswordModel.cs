using System.ComponentModel.DataAnnotations;

namespace Car2Go.Web.ViewModels.Users
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
