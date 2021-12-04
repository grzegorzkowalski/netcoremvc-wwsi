using FilmDB.Logic;
using FilmDB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            var manager = new FilmManager();
            //var film = new FilmModel();
            //film.ID = 1;
            //film.Title = "Deszczowa piosenka";
            //film.Year = 1935;
            //manager.AddFilm(film);
            //manager.RemoveFilm(4);
            //manager.RemoveFilm(8);
            return View();
        }
    }
}
