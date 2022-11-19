using FilmDB.Logic;
using FilmDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmDB.Controllers
{
    public class FilmController : Controller
    {
        FilmManager filmManager = new FilmManager();
        public IActionResult Index()
        {
            FilmModel film = new FilmModel()
            {
                Name = "Rambo",
                Year = 1985,
            };
            filmManager.AddFilm(film);

            return View();
        }
    }
}
