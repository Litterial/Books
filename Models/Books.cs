using BookApp.Interface;
namespace BookApp.Models
{
    public class Book
    {
        public Book()
        {
        }
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public uint Pages { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }


    }
}