using Microsoft.AspNetCore.Mvc;
using System;
using Z502.Logic;
using Z502.Models;

namespace Z502.Controllers
{
    public class FilmController : Controller
    {
        FilmManager filmManager = new FilmManager();
        public IActionResult Index()
        {
            var random = new Random();
            var film = new FilmModel()
            {

                Title = $"Rambo{random.Next(1, 100)}",
                Year = 1999
            };
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
