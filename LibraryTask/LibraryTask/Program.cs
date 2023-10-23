using LibraryTask.Models;
using System;
using System.Security.Cryptography.X509Certificates;

namespace LibraryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("===============");
            //Console.WriteLine("Ana Menyu");
            //Console.WriteLine("==============="); 

            //string input = Console.ReadLine();

            //switch (input)
            //{
            //    case "1":
            //        Console.WriteLine("Yeni kitabxana yarat");
            //        Console.WriteLine("Kitabxanin adini daxil edirsiniz");
            //        string name = Console.ReadLine();
            //        Library library = new(name);
            //        libraries.Add(library);
            //        break;

            //    case "2":
            //        Console.WriteLine("Yeni kateqoriya yarat");
            //        Console.WriteLine("Kateqoriya adini daxil edisiniz");
            //        string categoryname = Console.ReadLine();
            //        Category category = new(categoryname);
            //        break;

            //    case "3":
            //        Console.WriteLine("Yeni kitab yarat");
            //        Console.WriteLine("Kitabin adini yazarsiniz");
            //        string bookname = Console.ReadLine();
            //        Book book = new(bookname);
            //        books.Add(book);
            //        break;


            //List<Library> libraries = new List<Library>();
            //List<Category> categories = new List<Category>();
            //List<Book> books = new List<Book>();


            Console.WriteLine("=======================");
            Console.WriteLine("Ana Menyu");
            Console.WriteLine("=======================");
            Console.WriteLine("[1] Yeni kitabaxana yarat");
            Console.WriteLine("[2] Yeni kateqoriya yarat");
            Console.WriteLine("[3] Yeni kitab yarat");
            Console.WriteLine("[4] kitabxanaya daxil ol");
            Console.WriteLine("[0] Proqramdan cix");
            Console.WriteLine("Secimden cix");

            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "0":
                        break;
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            






        }
    }
}