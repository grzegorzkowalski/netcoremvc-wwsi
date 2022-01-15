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
        private readonly IFilmManager _film;

        public FilmController(IFilmManager film) 
        {
            _film = film;   
        }
        public IActionResult Index()
        {
            var films = _film.GetFilms();

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
            _film.AddFilm(film);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var film = _film.GetFilm(id);
            return View(film);
        }

        [HttpPost]
        public IActionResult RemoveConfirm(int id)
        {
            try
            {
                var film = _film.GetFilm(id);
                _film.RemoveFilm(film.ID);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var film = _film.GetFilm(id);
            return View(film);
        }

        [HttpPost]
        public IActionResult Edit(FilmModel film)
        {
            _film.UpdateFilm(film);
            return RedirectToAction("Index");
        }
    }
}
