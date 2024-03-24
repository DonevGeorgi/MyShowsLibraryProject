using Microsoft.AspNetCore.Mvc;

namespace MyShowsLibraryProject.Areas.Administration.Controllers
{
    public class SerieController : AdministrationController
    {
       

        public IActionResult Index()
        {
            return View();
        }
    }
}
