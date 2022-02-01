using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Car2Go.Common;
using Car2Go.Web.Controllers;

namespace Car2Go.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
