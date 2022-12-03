using Microsoft.AspNetCore.Mvc;
using Z504.Logic;
using Z504.Models;

namespace Z504.Controllers
{
    public class FilmController : Controller
    {
        FilmManager filmManager = new FilmManager();
        public IActionResult Index()
        {
            FilmModel film = new FilmModel();
            film.Name = "Rambo2";
            film.Year = "1980";
            //film.ID = 999;

            filmManager.AddFilm(film);
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
            filmManager.AddFilm(filmModel);
            return RedirectToAction("Index");
        }
    }
}
