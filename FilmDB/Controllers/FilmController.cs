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
            manager.AddFilm(new FilmModel()
            {
                ID = 0,
                Title = "Matrix",
                Year = 1999
            });

            return View();
        }
    }
}
