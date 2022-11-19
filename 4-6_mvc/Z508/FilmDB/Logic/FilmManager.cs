using FilmDB.Models;
using System.Collections.Generic;
using System.Linq;

namespace FilmDB.Logic
{
    public class FilmManager
    {
        public FilmManager AddFilm(FilmModel filmModel)
        {
            using (var context = new FilmContext())
            {
                context.Films.Add(filmModel);
                context.SaveChanges();
                //try
                //{
                //    context.Films.Add(filmModel);
                //    context.SaveChanges();
                //}
                //catch (System.Exception e)
                //{
                //    filmModel.ID = 0;
                //    context.Films.Add(filmModel);
                //    context.SaveChanges();
                //}
            }
            return this;
        }

        public FilmManager RemoveFilm(int id)
        {
            using (var context = new FilmContext())
            {
                FilmModel filmToDelete = context.Films.FirstOrDefault(x => x.ID == id);
                context.Films.Remove(filmToDelete);
                context.SaveChanges();
            }
            return this;
        }

        public FilmManager UpdateFilm(FilmModel filmModel)
        {
            return this;
        }

        public FilmManager ChangeTitle(int id, string newTitle)
        {
            return this;
        }

        public FilmManager GetFilm(int id)
        {
            return null;
        }

        public List<FilmModel> GetFilms()
        {
            return null;
        }
    }
}
