using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmManager
{
    public class AboutFilm
    {
        public AboutFilm(string title, string director, IEnumerable<string> actors) : this(title, director)
        {
            this.Actors = actors;
        }
        public AboutFilm(string title, string director) : this(title)
        {
            this.Director = director;
        }
        public AboutFilm(IEnumerable<string> actors)
        {
            this.Actors = actors;
        }
        public AboutFilm(string title)
        {
            this.Title = title;
        }
        public AboutFilm()
        {
            Title = new string("");
            Actors = new List<string>();
            Director = new string("");
        }
        public string Title { set; get; }
        public IEnumerable<string> Actors { set; get; }
        public string Director { set; get; }
    }
}
