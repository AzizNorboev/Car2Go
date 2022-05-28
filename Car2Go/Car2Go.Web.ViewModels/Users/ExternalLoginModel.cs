using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace Car2Go.Web.ViewModels.Users
{
    public class ExternalLoginModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //public ClaimsPrincipal Principal { get; set; }
    }
}
