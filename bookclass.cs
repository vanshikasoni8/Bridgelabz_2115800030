//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2feb
//{
//    internal class bookclass
//    {
//        public string Title { get; set; }
//        public string Author { get; set; }
//        public double Price { get; set; }

//        // Default Constructor
//        public bookclass()
//        {
//            Title = "Unknown";
//            Author = "Unknown";
//            Price = 0.0;
//        }

//        // Parameterized Constructor
//        public bookclass(string title, string author, double price)
//        {
//            Title = title;
//            Author = author;
//            Price = price;
//        }

//        // Display Method
//        public void Display()
//        {
//            Console.WriteLine($"Title: {Title}, Author: {Author}, Price: ${Price}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Using Default Constructor
//            bookclass book1 = new bookclass();
//            book1.Display();

//            // Using Parameterized Constructor
//            bookclass book2 = new bookclass("The Great Gatsby", "F. Scott Fitzgerald", 10.99);
//            book2.Display();
//        }

//    }
//}
