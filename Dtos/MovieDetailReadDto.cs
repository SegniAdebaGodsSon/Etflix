using EtFlix_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtFlix_Api.Dtos
{
    public class MovieDetailReadDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public decimal Runtime { get; set; }

        public int Rating { get; set; }

        public string Summary { get; set; }

        public string Language { get; set; }

        public string Country { get; set; }

        public string Director { get; set; }

        public string Image { get; set; }

        public string Link { get; set; }

        public Actor[] Actors { get; set; }
    }
}
