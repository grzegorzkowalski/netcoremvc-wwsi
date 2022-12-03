using System.Collections.Generic;
using System.Linq;
using Z504.Models;

namespace Z504.Logic
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
                //catch (System.Exception)
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
            using (var contex = new FilmContext())
            {
                var filmToDelete = contex.Films.SingleOrDefault(x => x.ID == id);
                contex.Films.Remove(filmToDelete);
                contex.SaveChanges();
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
                var filmToChangeTitle = context.Films.Single(x => x.ID == id);
                if (string.IsNullOrEmpty(newTitle))
                {
                    newTitle = "Brak tytułu";
                }
                filmToChangeTitle.Name = newTitle;
                this.UpdateFilm(filmToChangeTitle);
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
                var filmList = context.Films.ToList();
                return filmList;
            }
        }
    }
}
