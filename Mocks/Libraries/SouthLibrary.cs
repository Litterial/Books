//using System.Collections.Generic;
//using BookApp.Interface;
//using BookApp.Models;
//using System.Linq;
//namespace BookApp.Mocks
//{
//    public class SouthLibrary : ILibraryDistrict
//    {
//        private readonly SouthLibrary _southLibrary;
//        private Library _library;
//        private IEnumerable<Author> _authors;
//        private Book _book;

//        public SouthLibrary(Library library, IEnumerable<Author> authors, Book book)
//        {
//            _library = library;
//            _authors = authors;
//            _book = book;
//        }
//        public IEnumerable<Author> VeteranAuthor(IEnumerable<Author> authors)
//        {
//            IEnumerable<Author> vets = new List<Author>();
//            foreach (Author author in _authors)
//            {
//                if (author.Books.Count > 10)
//                    vets.Append(author);

//            }
//            return vets;
//        }

//        public bool IsNovel(Book book)
//        {
//            if (_book.Pages >= 150)
//                return true;
//            return false;
//        }

//        public IEnumerable<Employee> RookiePayGrade(Library library)
//        {
//            List<Employee> employees = _library.employees;
//            List<Employee> rookies = new List<Employee>();
//            {
//                foreach (Employee rookie in employees)
//                {
//                    if (rookie.Salary < 40000)
//                        rookies.Add(rookie);
//                }

//                return rookies;
//            }
//        }
//    }
//}