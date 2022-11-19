using System.Collections.Generic;
using System.Linq;
using Z502.Models;

namespace Z502.Logic
{
    public class FilmManager
    {
        public FilmManager AddFilm(FilmModel filmModel)
        {
            using (var context = new FilmContext())
            {
                context.Add(filmModel);
                context.SaveChanges();
            }
            return this;
        }

        public FilmManager RemoveFilm(int id)
        {
            using (var context = new FilmContext())
            {
                var filmToDelete = context.Films.Single(x => x.ID == id);
                context.Remove(filmToDelete);
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
                var filmToChangeTitle = context.Films.Single(x => x.ID == id);
                filmToChangeTitle.Title = newTitle;
                context.Update(filmToChangeTitle);
                context.SaveChanges();
            }
            return this;
        }

        public FilmModel GetFilm(int id)
        {
            FilmModel filmById;
            using (var context = new FilmContext())
            {
                filmById = context.Films.Single(x => x.ID == id);
            }
            return filmById;
        }

        public List<FilmModel> GetFilms()
        {
            List<FilmModel> filmList;
            using (var context = new FilmContext())
            {
                filmList = context.Films.ToList();
            }
            return filmList;
        }
    }
}
