using FilmBD503.Logic;
using FilmBD503.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmBD503.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            var manager = new FilmManager();
            var films = manager.GetFilms();
            return View(films);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(FilmModel film)
        {
            var filmManager = new FilmManager();
            filmManager.AddFilm(film);
            return RedirectToAction("Index");
        }
    }
}
