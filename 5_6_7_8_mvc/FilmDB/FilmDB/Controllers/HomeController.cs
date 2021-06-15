using FilmDB.Logic;
using FilmDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Add(FilmModel filmModel)
        {
            var filmManager = new FilmManager();
            try
            {
                filmManager.AddFilm(filmModel);
                return View("/Views/Film/Index.cshtml");
            }
            catch (Exception)
            {
                return View("/Views/Film/Add.cshtml", filmModel);
            }
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var filmManager = new FilmManager();
            var film = filmManager.GetFilm(id);
            return View(film.Film);
        }

        [HttpPost]
        public IActionResult RemoveConfirm(int id)
        {
            var filmManager = new FilmManager();
            if (filmManager.GetFilm(id) != null)
            {
                filmManager.RemoveFilm(id);
            }

            return View("/Views/Film/Index.cshtml", filmManager.GetFilms());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var filmManager = new FilmManager();
            var film = filmManager.GetFilm(id);
            return View(film.Film);
        }

        [HttpPost]
        public IActionResult Edit(FilmModel filmModel)
        {
            var filmManager = new FilmManager();
            filmManager.UpdateFilm(filmModel);
            return View("/Views/Film/Index.cshtml", filmManager.GetFilms());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
