using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31jan
{
    internal class book
    {
        public string Bookname { get; set; }
        public string title { get; set; }
        public double cost { get; set; }
    
        public book(string Bookname, string title, double cost)
        {

            this.Bookname = Bookname;
            this.title = title;
            this.cost = cost;
        }
        public void ShowDetail()
        {
            Console.WriteLine($" BookName : {Bookname}");
            Console.WriteLine($"Title : {title}");
            Console.WriteLine($"Cost : {cost}");

        }
        static void Main()
        {
            book book1 = new book("The Great Gatsby", "F. Scott Fitzgerald", 10.99);
            book book2 = new book("1984", "George Orwell", 8.99);

            book1.ShowDetail();
            Console.WriteLine("---");
            book2.ShowDetail();



        }
    }
}
