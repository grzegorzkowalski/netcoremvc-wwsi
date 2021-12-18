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


        [HttpGet]
        public IActionResult Remove (int id)
        {
            var filmManager = new FilmManager();
            var film = filmManager.GetFilm(id);
            return View(film);
        }

        [HttpPost]
        public IActionResult RemoveConfirm (int id)
        {
            var filmManager = new FilmManager();

            try
            {
                var film = filmManager.GetFilm(id);
                filmManager.RemoveFilm(film.ID);
                return RedirectToAction("Index");
            }
            catch (System.Exception)
            {
                throw;
            }

        }

        [HttpGet]
        public IActionResult Edit (int id)
        {
            var filmManager = new FilmManager();
            var film = filmManager.GetFilm(id);
            return View(film);
        }

        [HttpPost]
        public IActionResult Edit (FilmModel filmModel)
        {
            var filmManager = new FilmManager();
            filmManager.UpdateFilm(filmModel);
            return RedirectToAction("Index");
        }
    }
}
