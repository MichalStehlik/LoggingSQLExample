using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingSQLTest.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [ForeignKey("GameId")]
        public Game Game { get; set; }
        [Required]
        public int GameId { get; set; }
    }
}
