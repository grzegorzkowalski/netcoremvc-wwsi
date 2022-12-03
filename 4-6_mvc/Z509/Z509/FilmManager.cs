using System;
using System.Collections.Generic;
using System.Linq;
using Z509.Models;

namespace Z509
{
    public class FilmManager
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
                catch (System.Exception e)
                {
                    filmModel.Id = 0;
                    context.Films.Add(filmModel);
                    context.SaveChanges();
                }
            }
                return this;
        }

        public FilmManager RemoveFilm(int id)
        {
            using (var context = new FilmContext())
            {
                FilmModel filmToDelete = context.Films.SingleOrDefault(x => x.Id == id);
                if (filmToDelete != null) 
                {
                    context.Films.Remove(filmToDelete);
                    context.SaveChanges();
                }
            }
                return this;
        }

        public void UpdateFilm(FilmModel filmModel)
        {
            using (var context = new FilmContext())
            {
                context.Films.Update(filmModel);
                context.SaveChanges();
            }
        }

        public void ChangeTitle(int id, string newTitle)
        {
            using (var context = new FilmContext())
            {
                FilmModel film = this.GetFilm(id);
                if (String.IsNullOrEmpty(newTitle))
                {
                    newTitle = "Brak tytułu";
                }
                film.Name = newTitle;
                context.Films.Update(film);
                context.SaveChanges();
            }
    }

        public FilmModel GetFilm(int id)
        {
            using (var context = new FilmContext())
            {
                return context.Films.SingleOrDefault(x => x.Id == id);
            }
        }

        public List<FilmModel> GetFilms()
        {
            using (var context = new FilmContext())
            {
                return context.Films.ToList();
            }
        }
    }
}
