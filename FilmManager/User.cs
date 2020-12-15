using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmManager
{
    public class User
    {
        public string Name { set; get; }
        public float RateFilm(int filmId, FilmCollection films)
        {
            float appraisal = 0;
            FilmInfo film = new FilmInfo();
            film = films.FindFilmById(filmId);
            UserFilmRating userFilmRating = new UserFilmRating(filmId);
            
            return appraisal;
        }
    }
}
