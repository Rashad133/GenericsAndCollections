using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask.Models
{
    internal class Library:Base
    {
        private static int _count = 1;
        List<Book> _books = new List<Book>();

        public Library(string name)
        {
            Id = _count++;
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void ListAllBooks()
        {
            foreach(Book book in _books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
