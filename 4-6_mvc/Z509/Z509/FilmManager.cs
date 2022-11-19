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
