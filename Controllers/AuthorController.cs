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

    [Route("[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private MyContext _context;
        public AuthorsController(MyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Authors()
        {

            List<Author> authors = await _context.Authors.ToListAsync();
            if (authors.Count == 0)
                return NotFound("There were no Authors found");
            return Ok(authors);
        }

        [HttpGet("create")]
        public string Test()
        {

            return "test";
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> FindAuthor(int id)
        {
            Author author = await _context.Authors.FindAsync(id);

            if (author == null)
            {
                return NotFound("Author not found");
            }

            return Ok(author);
        }



        [HttpPost("create")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromBody]Author author)
        {
            if (!ModelState.IsValid)
                return Conflict(author);

            _context.Authors.Add(author);
            await _context.SaveChangesAsync();
            return Ok(author);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateAuthor(int id,[FromBody] Author author)
        {
            Author changeAuthor = await _context.Authors.FindAsync(id);
                if (changeAuthor == null)
                    return NotFound("Author not found");
            changeAuthor.Name = author.Name;
            await _context.SaveChangesAsync();
            return Ok(changeAuthor);
        }

    }

}

