using EtFlix_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtFlix_Api.Data
{
    public interface IEtFlixRepo
    {
        bool saveChanges();


        IEnumerable<Movie> GetAllMovies();
        IEnumerable<Genre> GetAllGenres();
        IEnumerable<Actor> GetMovieActors(int movieId);
        Movie GetMovieById(int id);


        void CreateMovie(Movie movie);
    }
}
