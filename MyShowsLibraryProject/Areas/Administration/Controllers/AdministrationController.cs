using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyShowsLibraryProject.Areas.Administration.Controllers
{
    [Authorize(Roles = "Administrator")]
    [Area("Administration")]
    public class AdministrationController : Controller
    {
    }
}
