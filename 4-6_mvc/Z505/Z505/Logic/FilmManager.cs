using System.Collections.Generic;
using System.Linq;
using Z505.Models;

namespace Z505.Logic
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

                    if (filmModel.ID != 0)
                    {
                        filmModel.ID = 0;
                        context.Films.Add(filmModel);
                        context.SaveChanges();
                    }
                }

            }
            return this;
        }

        public FilmManager RemoveFilm(int id)
        {
            using (var context = new FilmContext())
            {
                var film = context.Films.Single(x => x.ID == id);
                context.Films.Remove(film);
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
                var film = context.Films.Single(x => x.ID == id);
                if (string.IsNullOrEmpty(newTitle))
                {
                    newTitle = "Brak tytułu";
                }
                film.Title = newTitle;
                this.UpdateFilm(film);
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
