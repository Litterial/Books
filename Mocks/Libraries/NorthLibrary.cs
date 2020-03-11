using System.Collections.Generic;
using BookApp.Interface;
using BookApp.Models;
using System.Linq;
namespace BookApp.Mocks
{
    public class NorthLibrary : ILibraryDistrict
    {
        private readonly NorthLibrary _northlibrary;
        private Library _library;
        private IEnumerable<Author> _authors;
        private Book _book;

        public NorthLibrary(Library library, IEnumerable<Author> authors, Book book)
        {
            _library = library;
            _authors = authors;
            _book = book;
        }
        public IEnumerable<Author> VeteranAuthor(IEnumerable<Author> authors)
        {
            IEnumerable<Author> vets = new List<Author>();
            foreach (Author author in _authors)
            {
                if (author.Books.Count > 15)
                    vets.Append(author);

            }
            return vets;
        }

        public bool IsNovel(Book book)
        {
            if (_book.Pages >= 200)
                return true;
            return false;
        }

        public IEnumerable<Employee> RookiePayGrade(Library library)
        {
            List<Employee> employees = _library.employees;
            List<Employee> rookies = new List<Employee>();
            {
                foreach (Employee rookie in employees)
                {
                    if (rookie.Salary < 50000)
                        rookies.Add(rookie);
                }

                return rookies;
            }
        }
    }
}