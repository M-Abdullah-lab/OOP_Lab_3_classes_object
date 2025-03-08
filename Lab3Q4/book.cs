using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    class book
    {
        public string ISBN;
        public string Title;
        public string MajorArea;
        public string SubArea;
        public double price;
        public int NumberOfPages;

        public static book[] InputBooks()
        {
            book[] books = new book[20];
            for (int i = 0; i < books.Length; i++)
            {
                books[i] = new book();
                Console.WriteLine($"Enter details for Book {i + 1}:");
                Console.Write("ISBN: ");
                books[i].ISBN = Console.ReadLine();
                Console.Write("Title: ");
                books[i].Title = Console.ReadLine();
                Console.Write("Price: ");
                books[i].price = double.Parse(Console.ReadLine());
                Console.Write("Major Area: ");
                books[i].MajorArea = Console.ReadLine();
                Console.Write("Sub Area: ");
                books[i].SubArea = Console.ReadLine();
                Console.Write("Number of Pages: ");
                books[i].NumberOfPages = int.Parse(Console.ReadLine());
            }
            return books;
        }
        public static void PrintBooks(book[] books)
        {
            Console.WriteLine("\nDisplaying Book Details:");
            foreach (var book in books)
            {
                Console.WriteLine($"ISBN: {book.ISBN}, Title: {book.Title}, Price: {book.price:C}, Major Area: {book.MajorArea}, Sub Area: {book.SubArea}, Pages: {book.NumberOfPages}");
            }
        }
    }
}
/*Create a Class Book (ISBN, Title, Price, Major Area, Sub Area, and No. of Pages). Take
the input of 20 books from the user through a method InputBooks and display these
books through PrintBooks method. Write another method SearchBook which
searches the specified book by taking book title as argument and return the complete
details of the book*/