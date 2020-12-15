using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmManager
{
    public class UserFilmRating
    {
        public int UserId { set; get; }
        public int FilmId { set; get; }
        public float Rating { set; get; }
        public UserFilmRating()
        {
        }

        public UserFilmRating(int filmId)
        {
            FilmId = filmId;
        }
    }
}
