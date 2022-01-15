using FilmDB505.Models;
using System.Collections.Generic;

namespace FilmDB505.Logic
{
    public interface IFilmManager
    {
        FilmModel Film { get; set; }

        FilmManager AddFilm(FilmModel filmModel);
        FilmManager ChangeTitle(int id, string newTitle);
        FilmModel GetFilm(int id);
        List<FilmModel> GetFilms();
        FilmManager RemoveFilm(int id);
        FilmManager UpdateFilm(FilmModel filmModel);
        FilmManager Test();
    }
}