using System;
using System.Collections.Generic;
using System.Linq;
using BookApp.Models;
using BookApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController
    {
        private MyContext _context;
        public BooksController(MyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Book> Books()
        {
            List<Book> books = _context.Books.ToList();
            if (books.Count == 0)
                books = new List<Book>();
            return books;
        }
    }
}
