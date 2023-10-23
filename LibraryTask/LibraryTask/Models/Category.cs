using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask.Models
{
    internal class Category:Base
    {
        private static int _count = 1;
        public Category(string categoryname)
        {
            Name = categoryname;
            Id = _count++;
        }
    }
}
