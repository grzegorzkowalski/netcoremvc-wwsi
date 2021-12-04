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
            manager.ChangeTitle(10, null);
            manager.ChangeTitle(12, "Śniegowa piosenka");
            return View();
        }
    }
}
