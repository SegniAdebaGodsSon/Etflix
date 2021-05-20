using EtFlix_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtFlix_Api.Data
{
    public class MockEtFlixRepo : IEtFlixRepo
    {
        public IEnumerable<Genre> GetAllGenres()
        {
            var genres = new List<Genre>
            {
                new Genre { Id = 0, Name = "Action" },
                new Genre { Id = 1, Name = "Romance" }
            };
            return genres;
        }

        public Movie GetMovieById(int id)
        {
            return new Movie { Id=0, Country="Ethiopia", Date= new DateTime(2014,4,5),
                Director = "Segni Adeba",
                Image = "image 1",
                Language = "Amharic",
                Link = "afg",
                Rating = 9,
                Runtime = 2.3M,
                Summary="This is Segni's Movie"};

        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var movies = new List<Movie>
            {
                new Movie { Id=0, Country="Ethiopia", Date= new DateTime(2014,4,5),
                Director = "Segni Adeba",
                Image = "image 1",
                Language = "Amharic",
                Link = "afg",
                Rating = 9,
                Runtime = 2.3M,
                Summary="This is Segni's Movie"},

                new Movie { Id=1, Country="Ethiopia", Date= new DateTime(2014,4,5),
                Director = "Segni Adeba",
                Image = "image 1",
                Language = "Amharic",
                Link = "afg",
                Rating = 9,
                Runtime = 2.3M,
                Summary="This is Segni's Movie"},

                new Movie { Id=2, Country="Ethiopia", Date= new DateTime(2014,4,5),
                Director = "Segni Adeba",
                Image = "image 1",
                Language = "Amharic",
                Link = "afg",
                Rating = 9,
                Runtime = 2.3M,
                Summary="This is Segni's Movie"}
            };
            return movies;

        }
    }
}
