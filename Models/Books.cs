using BookApp.Interface;
using System.ComponentModel.DataAnnotations;
namespace BookApp.Models
{
    public class Book
    {
        public Book()
        {
        }
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public uint Pages { get; set; }

        [Required]
        public int AuthorId { get; set; }


    }
}