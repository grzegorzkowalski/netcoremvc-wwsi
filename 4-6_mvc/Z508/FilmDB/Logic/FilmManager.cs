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

        public void UpdateFilm(FilmModel film)
        {
            using (var context = new FilmContext())
            {
                context.Films.Update(film);
                context.SaveChanges();
            }
        }

        public FilmManager ChangeTitle(int id, string newTitle)
        {
            using (var context = new FilmContext())
            {
                var film = this.GetFilm(id);
                if (string.IsNullOrEmpty(newTitle)) {
                    newTitle = "Brak tytułu";
                }
                film.Name = newTitle;
                context.Films.Update(film);
                context.SaveChanges();
            }
            return this;
        }

        public FilmModel GetFilm(int id)
        {
            using (var contex = new FilmContext())
            {
                return contex.Films.Single(x => x.ID == id);
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
