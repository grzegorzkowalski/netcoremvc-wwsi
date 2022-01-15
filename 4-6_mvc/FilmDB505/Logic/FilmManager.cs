using FilmDB505.Contexts;
using FilmDB505.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmDB505.Logic
{
    public class FilmManager : IFilmManager
    {
        private readonly FilmContext _filmContext;
        public FilmManager(FilmContext filmContext)
        {
            _filmContext = filmContext;
        }
        public FilmModel Film { get; set; }
        public FilmManager AddFilm(FilmModel filmModel)
        {
            _filmContext.Films.Add(filmModel);
            try
            {
                _filmContext.SaveChanges();
            }
            catch (Exception)
            {
                if (filmModel.ID != 0)
                {
                    filmModel.ID = 0;
                    _filmContext.SaveChanges();
                }
            }
            return this;
        }
        public FilmManager RemoveFilm(int id)
        {
            var film = _filmContext.Films.Single(x => x.ID == id);
            _filmContext.Films.Remove(film);
            _filmContext.SaveChanges();
            return this;
        }

        public FilmManager UpdateFilm(FilmModel filmModel)
        {
            _filmContext.Films.Update(filmModel);
            _filmContext.SaveChanges();
            return this;
        }

        public FilmManager ChangeTitle(int id, string newTitle)
        {
            GetFilm(id);
            if (String.IsNullOrEmpty(newTitle))
            {
                Film.Title = "Brak tytuly";
            }
            else
            {
                Film.Title = newTitle;
            }
            UpdateFilm(Film);
            return this;
        }

        public FilmModel GetFilm(int id)
        {
            var film = _filmContext.Films.Single(x => x.ID == id);
            return film;
        }

        public List<FilmModel> GetFilms()
        {
            return _filmContext.Films.ToList();
        }

        public FilmManager Test()
        {
            throw new NotImplementedException();
        }
    }
}
