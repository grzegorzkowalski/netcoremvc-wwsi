using Z510.Models;
using Microsoft.AspNetCore.Mvc;
using Z510.Logic;
using FilmDB.Models;

namespace Z510.Controllers
{
    public class FilmController : Controller
    {
        FilmManager filmManager = new FilmManager();
        public IActionResult Index()
        {
            FilmModel film = new FilmModel()
            {
                Name = "Rambo",
                Year = 1985
            };
            filmManager.AddFilm(film);
            filmManager.RemoveFilm(3);          

            return View();
        }
    }
}
