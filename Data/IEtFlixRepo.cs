using EtFlix_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtFlix_Api.Data
{
    public interface IEtFlixRepo
    {
        IEnumerable<Movie> GetAllMovies();
        IEnumerable<Genre> GetAllGenres();
        Movie GetMovieById(int id);
    }
}
