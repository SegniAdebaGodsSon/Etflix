using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EtFlix_Api.Dtos
{
    public class MovieCreateDto 
    {
        [MaxLength(25)]
        [Required]
        public string Title { get; set; }


        public DateTime Date { get; set; }


        [Required]
        public decimal Runtime { get; set; }

        
        [Required]
        public int Rating { get; set; }


        [MaxLength(10000)]
        [Required]
        public string Summary { get; set; }


        [MaxLength(20)]
        [Required]
        public string Language { get; set; }


        [MaxLength(20)]
        [Required]
        public string Country { get; set; }


        [MaxLength(30)]
        [Required]
        public string Director { get; set; }


        public string Image { get; set; }

        public string Link { get; set; }
    }
}
