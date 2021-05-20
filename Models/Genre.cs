using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EtFlix_Api.Models
{
    [Table("Genre")]
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

    }
}
