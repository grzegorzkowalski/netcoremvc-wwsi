using FilmDB.Context;
using FilmDB.Logic;
using FilmDB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmDB.Controllers
{
    public class FilmController : Controller
    {
        private readonly FilmManager _filmManager;

        public FilmController(FilmManager filmManager)
        {
            _filmManager = filmManager;
        }

        public IActionResult Index()
        {
            var films = _filmManager.GetFilms();
            return View(films);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
