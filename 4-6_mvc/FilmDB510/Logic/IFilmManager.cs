using FilmDB510.Models;
using System.Collections.Generic;

namespace FilmDB510.Logic
{
    public interface IFilmManager
    {
        FilmManager AddFilm(FilmModel filmModel);
        FilmManager ChangeTitle(int id, string newTitle);
        FilmModel GetFilm(int id);
        List<FilmModel> GetFilms();
        FilmManager RemoveFilm(int id);
        FilmManager UpdateFilm(FilmModel filmModel);
    }
}