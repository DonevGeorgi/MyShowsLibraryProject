using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyShowsLibraryProject.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
