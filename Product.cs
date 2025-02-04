//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2feb
//{
//    internal class Product
//    {
//        public static int TotalProducts = 0;

//        // Instance variables for product name and price
//        public string ProductName { get; set; }
//        public decimal Price { get; set; }

//        // Constructor to initialize product name and price
//        public Product(string productName, decimal price)
//        {
//            ProductName = productName;
//            Price = price;
//            // Increment TotalProducts whenever a new product is created
//            TotalProducts++;
//        }

//        // Instance method to display product details
//        public void DisplayProductDetails()
//        {
//            Console.WriteLine($"Product Name: {ProductName}");
//            Console.WriteLine($"Price: ${Price}");
//        }

//        // Class method to display total number of products
//        public static void DisplayTotalProducts()
//        {
//            Console.WriteLine($"Total Products Created: {TotalProducts}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Creating products
//            Product product1 = new Product("Laptop", 1000.00m);
//            Product product2 = new Product("Smartphone", 500.00m);

//            // Displaying product details
//            product1.DisplayProductDetails();
//            product2.DisplayProductDetails();

//            // Displaying total products created
//            Product.DisplayTotalProducts();
//        }

//    }
//}
