using System;
using BookApp.Data;
using BookApp.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BookApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController
    {
        private MyContext _context;
        public AuthorController(MyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Author> Author()
        {
           return _context.Authors.ToList();
        }

    }
}
