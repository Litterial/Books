using System.Collections.Generic;
namespace BookApp.Models
{
    public class Author
    {
        public Author()
        {
           
        }
        public int Id { get; set;}
        public string Name { get; set;}
        public List<Book> Books { get; set;}
    }
}