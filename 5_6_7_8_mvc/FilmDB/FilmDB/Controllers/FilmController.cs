using FilmDB.Logic;
using FilmDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmDB.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            var filmManager = new FilmManager();
            var film = new FilmModel();
            film.Title = "Mimionki 2021";
            film.Year = 2021;
            film.ID = 1;
            filmManager.AddFilm(film);
            return View();
        }
    }
}
