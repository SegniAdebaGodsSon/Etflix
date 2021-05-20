using EtFlix_Api.Data;
using EtFlix_Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtFlix_Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : Controller
    {
        private readonly IEtFlixRepo _repository;

        public GenresController(IEtFlixRepo repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Genre>> GetAllGenres()
        {
            var genreItems = _repository.GetAllGenres();
            return Ok(genreItems);
        }
    }
}
