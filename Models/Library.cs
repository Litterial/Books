using System;
using System.Collections.Generic;
namespace BookApp.Models
{
    public class Library
    {
        public Library()
        {
         
        }
        public int LibraryId { get; set; }
        public string Name { get; set; }
        public List<Employee> employees { get; set; }

    }
}
