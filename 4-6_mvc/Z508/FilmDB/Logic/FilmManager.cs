using FilmDB.Models;
using System.Collections.Generic;

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
