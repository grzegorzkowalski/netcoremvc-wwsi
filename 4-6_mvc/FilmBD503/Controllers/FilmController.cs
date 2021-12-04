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
            //var film = new FilmModel();
            //film.ID = 5;
            //film.Title = "Jaś i Małgosia2";
            //film.Year = 1958;
            //manager.AddFilm(film);
            //manager.RemoveFilm(1);
            // manager.UpdateFilm(film);
            //manager.ChangeTitle(8, null);
            //var film = manager.GetFilm(8);
            //var films = manager.GetFilms();
            return View();
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
