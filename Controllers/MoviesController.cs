using EtFlix_Api.Data;
using EtFlix_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtFlix_Api.Controllers
{

    
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IEtFlixRepo _repository;

        public MoviesController(IEtFlixRepo repository)
        {
            _repository = repository;
        }

        // GET api/movies
        [HttpGet]
        public ActionResult <IEnumerable<Movie>> GetAllMovies()
        {
            var movieItems = _repository.GetAllMovies();
            return Ok(movieItems);
        }

        

        // GET api/movies/{id}
        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovieById(int id)
        {
            var movieItem = _repository.GetMovieById(id);
            return Ok(movieItem);
        }
    }
}
