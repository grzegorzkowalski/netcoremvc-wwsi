using Microsoft.AspNetCore.Mvc;
using Z505.Logic;
using Z505.Models;

namespace Z505.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            FilmManager filmManager = new FilmManager();
            FilmModel film = new FilmModel()
            {
                Title = "Rambo",
                Year = 1980
            };
            filmManager.AddFilm(film);
            
            return View();
        }
    }
}
