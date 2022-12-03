using FilmDB.Models;
using System.Collections.Generic;
using System.Linq;

namespace Z510.Logic
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
                    filmModel.ID = 0;
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
                FilmModel filmModelToDelete;
                filmModelToDelete = context.Films.Single(x => x.ID == id);
                context.Films.Remove(filmModelToDelete);
                context.SaveChanges();
            }
            return this;
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
                var filmModel = context.Films.Single(x => x.ID == id); 
                if (string.IsNullOrEmpty(newTitle))
                {
                    newTitle = "Brak Tytułu";
                }
                filmModel.Title = newTitle;
                this.UpdateFilm(filmModel);
            }
            return this;
        }

        public FilmModel GetFilm(int id)
        {
            using (var context = new FilmContext())
            {
                var film = context.Films.Single(x => x.ID == id);
                return film;
            }
        }

        public List<FilmModel> GetFilms()
        {
            using (var context = new FilmContext())
            {
                var film = context.Films.ToList();
                return film;
            }
        }
    }
}
