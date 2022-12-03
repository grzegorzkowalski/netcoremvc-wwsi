﻿using Z510.Models;
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
            var list = filmManager.GetFilms();
            return View(list);
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
