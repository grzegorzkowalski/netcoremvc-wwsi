using FilmDB505.Logic;
using FilmDB505.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB505.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            var fm = new FilmManager();
            var films = fm.GetFilms();

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
            var manager = new FilmManager();
            manager.AddFilm(film);
            return RedirectToAction("Index");
        }
    }
}
