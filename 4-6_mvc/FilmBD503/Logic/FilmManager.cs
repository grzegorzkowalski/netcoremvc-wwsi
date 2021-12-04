using FilmBD503.Contexts;
using FilmBD503.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmBD503.Logic
{
    public class FilmManager
    {
        public FilmManager AddFilm(FilmModel filmModel)
        {
            using (var context = new FilmContext())
            {
                context.Add(filmModel);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    filmModel.ID = 0;
                    context.Add(filmModel);
                    context.SaveChanges();
                }
            }
                return this;
        }

        public FilmManager RemoveFilm(int id)
        {
            using (var context = new FilmContext())
            {
                var film = context.Films.SingleOrDefault(x => x.ID == id);
                context.Remove(film);
                context.SaveChanges();
            }
                return this;
        }

        public FilmManager UpdateFilm(FilmModel filmModel)
        {
            using (var context = new FilmContext())
            {
                context.Update(filmModel);
                context.SaveChanges();
            }
            return this;
        }

        public FilmManager ChangeTitle(int id, string newTitle)
        {
            using (var context = new FilmContext())
            {
                var filmToEdit = context.Films.Single(x => x.ID == id);
                filmToEdit.Title = newTitle;
                if (String.IsNullOrEmpty(filmToEdit.Title))
                {
                    filmToEdit.Title = "Brak tytułu";
                }
                this.UpdateFilm(filmToEdit);
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
                var films = context.Films.ToList<FilmModel>();
                return films;
            }               
        }
    }
}
