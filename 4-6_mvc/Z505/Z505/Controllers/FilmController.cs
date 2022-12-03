using Microsoft.AspNetCore.Mvc;

namespace Z505.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
