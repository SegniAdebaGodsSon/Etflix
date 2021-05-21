using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtFlix_Api.Dtos
{
    public class MovieReadDto
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public decimal Runtime { get; set; }

        public int Rating { get; set; }

        public string Image { get; set; }

    }
}
