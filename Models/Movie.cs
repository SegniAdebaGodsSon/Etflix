using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EtFlix_Api.Models
{
    [Table("Movie")]
    public class Movie
    {

        [Key]
        public int Id { get; set; }

        
        [Column(TypeName="date")]
        public DateTime Date { get; set; }


        [Required]
        public decimal Runtime { get; set; }


        [Column(TypeName="integer")]
        [MaxLength(10)]
        [Required]
        public int Rating { get; set; }


        [Column(TypeName = "text")]
        [MaxLength(10000)]
        [Required]
        public string Summary { get; set; }


        [Column(TypeName = "text")]
        [MaxLength(20)]
        [Required]
        public string Language { get; set; }


        [Column(TypeName = "text")]
        [MaxLength(20)]
        [Required]
        public string Country { get; set; }


        [Column(TypeName = "text")]
        [MaxLength(30)]
        [Required]
        public string Director { get; set; }


        [Column(TypeName = "text")]
        public string Image { get; set; }


        [Column("VideoFileLink", TypeName = "text")]
        public string Link { get; set; }
    }
}
