//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2feb
//{
//    internal class Book
//    {
//        private string Title { get; set; }
//        private string Author { get; set; }
//        private double Price { get; set; }
//        private bool IsAvailable { get; set; }

//        // Constructor
//        public Book(string title, string author, double price)
//        {
//            Title = title;
//            Author = author;
//            Price = price;
//            IsAvailable = true;
//        }

//        // BorrowBook Method
//        public void BorrowBook()
//        {
//            if (IsAvailable)
//            {
//                IsAvailable = false;
//                Console.WriteLine($"You have borrowed '{Title}' by {Author}.");
//            }
//            else
//            {
//                Console.WriteLine($"Sorry, '{Title}' is currently unavailable.");
//            }
//        }

//        // Display Method
//        public void Display()
//        {
//            Console.WriteLine($"Title: {Title}, Author: {Author}, Price: ${Price}, Available: {IsAvailable}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Creating a book instance
//            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 10.99);
//            book1.Display();

//            book1.BorrowBook();
//            book1.Display();
//        }

//    }
//}
