using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmManager
{
    public class FilmInfo
    {
        public FilmInfo(string title, string director, IEnumerable<string> actors) : this(title, director)
        {
            this.Actors = actors;
        }
        public FilmInfo(string title, string director) : this(title)
        {
            this.Director = director;
        }
        public FilmInfo(IEnumerable<string> actors)
        {
            this.Actors = actors;
        }
        public FilmInfo(string title)
        {
            this.Title = title;
            Actors = new List<string>();
            Director = new string("");
            Id = IdOfNextFilm;
            IdOfNextFilm++;
        }

        public FilmInfo()
        {
            Title = new string("");
            Actors = new List<string>();
            Director = new string("");
            Keywords = new List<string>();
            Id = IdOfNextFilm;
            IdOfNextFilm++;
        }
        public static int IdOfNextFilm { set; get; } = 0;
        public int Id { set; get; }
        public string Title { set; get; }
        public IEnumerable<string> Actors { set; get; }
        public string Director { set; get; }
        public IEnumerable<string> Keywords { set; get; }
        public float Rating { set; get; }
        public bool Latest { set; get; }
        public float Appraisal { set; get; }
    }
}