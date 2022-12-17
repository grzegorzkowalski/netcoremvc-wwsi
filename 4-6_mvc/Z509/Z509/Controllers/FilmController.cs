using Microsoft.AspNetCore.Mvc;
using Z509.Models;

namespace Z509.Controllers
{
    public class FilmController : Controller
    {
        private readonly FilmManager filmManager = new FilmManager(); 
        public IActionResult Index()
        {
            var films = filmManager.GetFilms();

            return View(films);
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
        
        [HttpGet]
        public IActionResult Remove(int id)
        {
            var film = filmManager.GetFilm(id);
            return View(film);
        }

        [HttpPost]
        public IActionResult RemoveConfirm(int id)
        {
            filmManager.RemoveFilm(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var film = filmManager.GetFilm(id);
            return View(film);
        }

        [HttpPost]
        public IActionResult Edit(FilmModel film)
        {
            filmManager.UpdateFilm(film);
            return RedirectToAction("Index");
        }
    }
}
