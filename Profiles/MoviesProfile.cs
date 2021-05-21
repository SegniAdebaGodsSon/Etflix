using AutoMapper;
using EtFlix_Api.Dtos;
using EtFlix_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtFlix_Api.Profiles
{
    public class MoviesProfile : Profile
    {

        public MoviesProfile()
        {
            // source -> destination
            CreateMap<Movie, MovieReadDto>();       
            CreateMap<Movie, MovieDetailReadDto>();


            CreateMap<MovieCreateDto, Movie>();

        }
    }
}
