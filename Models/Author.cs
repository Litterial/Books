using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookApp.Models
{
    public class Author
    {
        public Author()
        {
           
        }
        public int Id { get; set;}

        [Required]
        public string Name { get; set;}
    }
}