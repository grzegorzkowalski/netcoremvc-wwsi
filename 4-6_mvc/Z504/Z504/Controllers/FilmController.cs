using Microsoft.AspNetCore.Mvc;

namespace Z504.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
