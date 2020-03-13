using System;
using BookApp.Data;
using BookApp.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController:ControllerBase
    {
        private MyContext _context;
        public BooksController(MyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Books()
        {
            List<Book> books = await _context.Books.ToListAsync();
            if (books.Count == 0)
                return NotFound("There were no Books found");
            return Ok(books);
        }



        [HttpPost("create")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromBody]Book book)
        {
            if (!ModelState.IsValid)
                return Conflict(book);

            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return Ok(book);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateAuthor(int id, [FromBody] Book book)
        {
            Book changeBook = await _context.Books.FindAsync(id);
            if (changeBook == null)
                return NotFound("Book not found");
            Author author = await _context.Authors.FindAsync(book.AuthorId);
                if(author == null)
                    return NotFound("Author does not exist");

            changeBook.Title = book.Title;
            changeBook.Genre = book.Genre;
            changeBook.Pages = book.Pages;
            changeBook.AuthorId = book.AuthorId;

            await _context.SaveChangesAsync();
            return Ok(changeBook);
        }
    }
}
