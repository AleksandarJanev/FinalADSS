using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTest4228.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        public string Photo { get; set; }
        [Display(Name = "Year of publishing")]
        [Range(1, int.MaxValue, ErrorMessage = "Year must be a positive number")]
        public int YearOfPublishing { get; set; }
        public ICollection<Client> Client { get; set; }
    }
}
