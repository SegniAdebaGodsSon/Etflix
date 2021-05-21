using AutoMapper;
using EtFlix_Api.Data;
using EtFlix_Api.Dtos;
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
        public readonly IMapper _mapper;

        public MoviesController(IEtFlixRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/movies
        [HttpGet]
        public ActionResult <IEnumerable<MovieReadDto>> GetAllMovies()
        {
            var movieItems = _repository.GetAllMovies();
            return Ok(_mapper.Map<IEnumerable<MovieReadDto>>(movieItems));
        }


        // GET api/movies/{id}
        [HttpGet("{id}", Name ="GetMovieById")]
        public ActionResult<MovieDetailReadDto> GetMovieById(int id)
        {
            var movieItem = _repository.GetMovieById(id);
            
            if(movieItem != null) 
                return Ok(_mapper.Map<MovieDetailReadDto>(movieItem));
            return NotFound();
        }
    
    
    
        // POST api/mocies
        [HttpPost]
        public ActionResult<MovieReadDto> CreateMovie(MovieCreateDto movieCreateDto)
        {
            var movieModel = _mapper.Map<Movie>(movieCreateDto);
            _repository.CreateMovie(movieModel);
            _repository.saveChanges();

            var movieReadDto = _mapper.Map<MovieReadDto>(movieModel);

            return CreatedAtRoute(nameof(GetMovieById), new { Id = movieReadDto.Id}, movieReadDto);
        }
    }
}
