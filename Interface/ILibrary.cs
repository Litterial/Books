using System.Collections.Generic;
using BookApp.Models;
namespace BookApp.Interface
{
    public interface ILibraryDistrict
    {
        IEnumerable<Author> VeteranAuthor(IEnumerable<Author> authors);
        bool IsNovel(Book book);
        IEnumerable<Employee> RookiePayGrade(Library library);
    }
}
