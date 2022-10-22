using FilmDB.Contexts;
using FilmDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB.Logic
{
    public class FilmManager : IFilmManager
    {

        public FilmManager AddFilm(FilmModel filmModel)
        {
            using (var context = new FilmContext())
            {
                try
                {
                    context.Films.Add(filmModel);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    filmModel.ID = 0;
                    context.Films.Add(filmModel);
                    context.SaveChanges();
                }

            }

            return this;
        }

        public void RemoveFilm(int id)
        {
            using (var context = new FilmContext())
            {
                var filmToDelete = context.Films.Single(x => x.ID == id);
                context.Films.Remove(filmToDelete);
                context.SaveChanges();
            }
        }

        public FilmManager UpdateFilm(FilmModel filmModel)
        {
            using (var context = new FilmContext())
            {
                context.Films.Update(filmModel);
                context.SaveChanges();
            }
            return this;
        }

        public FilmManager ChangeTitle(int id, string newTitle)
        {
            using (var context = new FilmContext())
            {
                var film = this.GetFilm(id);
                if (film != null)
                {
                    if (String.IsNullOrEmpty(newTitle))
                    {
                        film.Title = "Brak Tytułu";
                    }
                    else
                    {
                        film.Title = newTitle;
                    }
                    this.UpdateFilm(film);
                }

            }
            return this;
        }

        public FilmModel GetFilm(int id)
        {
            using (var context = new FilmContext())
            {
                var film = context.Films.SingleOrDefault(x => x.ID == id);
                return film;
            }
        }

        public List<FilmModel> GetFilms()
        {
            using (var context = new FilmContext())
            {
                return context.Films.ToList<FilmModel>();
            }
        }
    }
}
