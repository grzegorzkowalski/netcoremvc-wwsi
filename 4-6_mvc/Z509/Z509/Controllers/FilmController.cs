using Microsoft.AspNetCore.Mvc;
using Z509.Models;

namespace Z509.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            var film = new FilmModel()
            {
                Name = "Rambo",
                Year = 1974,
            };

            var filmManager = new FilmManager();
            filmManager.AddFilm(film);
            filmManager.RemoveFilm(3);
            filmManager.RemoveFilm(7);

            return View();
        }
    }
}
