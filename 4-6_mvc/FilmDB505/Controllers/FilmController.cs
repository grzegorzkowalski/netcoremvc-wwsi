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
            var film = new FilmModel();
            film.ID = 3;
            film.Title = "Titanic";
            film.Year = 1999;
            //fm.RemoveFilm(6);
            fm.UpdateFilm(film);

            return View();
        }
    }
}
