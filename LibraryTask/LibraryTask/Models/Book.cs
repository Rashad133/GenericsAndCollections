using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask.Models
{
    internal class Book:Base
    {
        private static int _count = 1;
        public string Author { get; set; }
        Category Category { get; set; }

        Book(string bookname, string author, Category category ) 
        { 

            Name = bookname;
            Author = author;
            Category = category;
            Id = _count++;

        }
    }
}
