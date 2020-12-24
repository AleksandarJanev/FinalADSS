using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTest4228.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(5, 150, ErrorMessage = "Year must be a positive number")]
        public int Age { get; set; }
        [Required]
        [Display(Name = "Library ID")]
        public int LibraryID { get; set; }
        public int BookID { get; set; }
        [ForeignKey("BookID")]
        public Book Book { get; set; }
    }
}
