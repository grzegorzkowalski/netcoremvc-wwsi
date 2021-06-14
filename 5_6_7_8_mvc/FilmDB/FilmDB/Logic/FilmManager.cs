using FilmDB.Context;
using FilmDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB.Logic
{
    public class FilmManager
    {
        public FilmModel Film { get; set; }
        public FilmManager AddFilm(FilmModel filmModel)
        {
            using (var context = new FilmContext())
            {
                context.Films.Add(filmModel);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    if (filmModel.ID != 0)
                    {
                        filmModel.ID = 0;
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
            GetFilm(id);
            if (String.IsNullOrEmpty(newTitle)) 
            {
                Film.Title = "Brak tytuly";
            }
            else
            {
                Film.Title = newTitle;
            }
            UpdateFilm(Film);
            return this;
        }

        public FilmManager GetFilm(int id)
        {
            using (var context = new FilmContext())
            {
                Film = context.Films.Single(x => x.ID == id);    
            }

            return this;
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
