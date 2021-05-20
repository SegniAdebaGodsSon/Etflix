using EtFlix_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtFlix_Api.Data
{
    public class PostgreSQLEtFlixRepo : IEtFlixRepo
    {
        private readonly EtFlixContext _context;

        public PostgreSQLEtFlixRepo(EtFlixContext context)
        {
            _context = context;
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            return _context.Genres.ToList();
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _context.Movies.ToList();
        }

        public Movie GetMovieById(int id)
        {
            return (Movie)_context.Movies.FirstOrDefault(movie => movie.Id == id);
        }
    }
}
