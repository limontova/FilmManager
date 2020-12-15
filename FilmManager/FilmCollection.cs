using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FilmManager
{
    public class FilmCollection
    {
        public List<FilmInfo> Films { set; get; } 

        public List<FilmInfo> SearchByKeyword(string keyword)
        {
            List<FilmInfo> films = new List<FilmInfo>();
            foreach (FilmInfo film in Films)
            {
                foreach (string keywordInFilm in film.Keywords)
                {
                    if(keywordInFilm == keyword)
                    {
                        films.Add(film);
                        break;
                    }
                }
            }
            return films;
        }

        public List<FilmInfo> SearchByDirector(string director)
        {
            List<FilmInfo> films = new List<FilmInfo>();
            foreach (FilmInfo film in Films)
            {
               if(film.Director == director)
               {
                    films.Add(film);
                    break;
               }
            }
            return films;
        }

        public List<FilmInfo> SearchByActor(string actor)
        {
            List<FilmInfo> films = new List<FilmInfo>();
            foreach (FilmInfo film in Films)
            {
                foreach (string actorInFilm in film.Actors)
                {
                    if (actorInFilm == actor)
                    {
                        films.Add(film);
                        break;
                    }
                }
            }
            return films;
        }

        public void AddFilm(FilmInfo filmToAdd)
        {
            Films.Add(filmToAdd);
        }

        public FilmInfo FindFilmById(int id)
        {
            List<FilmInfo> films = new List<FilmInfo>();
            foreach (FilmInfo film in Films)
            {
                if (film.Id == id)
                    return film;
            }
            return new FilmInfo();
        }

        private List<FilmInfo> QuickSort(List<FilmInfo> listToSort)
        {
            if (listToSort.Count <= 1)
                return listToSort;
            int pivotIndex = listToSort.Count / 2;
            FilmInfo pivot = listToSort[pivotIndex];
            List<FilmInfo> left = new List<FilmInfo>();
            List<FilmInfo> right = new List<FilmInfo>();

            for (int i = 0; i < listToSort.Count; i++)
            {
                if (i == pivotIndex) continue;

                if (listToSort[i].Rating <= pivot.Rating)
                {
                    left.Add(listToSort[i]);
                }
                else
                {
                    right.Add(listToSort[i]);   
                }
            }

            List<FilmInfo> sorted = QuickSort(left);
            sorted.Add(pivot);
            sorted.AddRange(QuickSort(right));
            return sorted;
        }

        public List<FilmInfo> GetFilmsSortedByRating()
        {
            return QuickSort(Films);
        }   
    }
}
