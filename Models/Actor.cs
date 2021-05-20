using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EtFlix_Api.Models
{
    [Table("Actor")]
    public class Actor
    {

        [Key]
        public int Id { get; set; }

        [Column("FirstName")]
        [MaxLength(20)]
        [Required]
        public string FirstName { get; set; }

        [Column("LastName")]
        [MaxLength(20)]
        [Required]
        public string LastName { get; set; }
        
        [Column("Gender")]
        [MaxLength(10)]
        [Required]
        public string Gender { get; set; }

    }
}
