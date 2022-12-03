using Microsoft.AspNetCore.Mvc;
using Z509.Models;

namespace Z509.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            var filmManager = new FilmManager();
            filmManager.ChangeTitle(4, null);

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(FilmModel filmModel)
        {
            var filmManager = new FilmManager();
            filmManager.AddFilm(filmModel);
            return RedirectToAction("Index");
        }
    }
}
