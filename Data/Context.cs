using BookApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        { }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Libraries { get; set; }
    }
}