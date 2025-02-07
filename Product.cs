//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _4jan
//{
//    internal class Product
//    {
//        private static double Discount = 10.0;

//        public readonly int ProductID;
//        public string ProductName;
//        public double Price;
//        public int Quantity;

//        public Product(int ProductID, string ProductName, double Price, int Quantity)
//        {
//            this.ProductID = ProductID;
//            this.ProductName = ProductName;
//            this.Price = Price;
//            this.Quantity = Quantity;
//        }

//        public static void UpdateDiscount(double newDiscount)
//        {
//            if (newDiscount >= 0)
//            {
//                Discount = newDiscount;
//                Console.WriteLine($"Discount updated to: {Discount}%");
//            }
//            else
//            {
//                Console.WriteLine("Invalid discount value. It must be non-negative.");
//            }
//        }

//        // Method to display product details using 'is' operator
//        public void DisplayProductDetails()
//        {
//            if (this is Product)
//            {
//                double finalPrice = Price - (Price * Discount / 100);
//                Console.WriteLine($"Product ID: {ProductID}");
//                Console.WriteLine($"Product Name: {ProductName}");
//                Console.WriteLine($"Original Price: {Price:C}");
//                Console.WriteLine($"Discount Applied: {Discount}%");
//                Console.WriteLine($"Final Price: {finalPrice:C}");
//                Console.WriteLine($"Quantity Available: {Quantity}");
//            }
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            Product product1 = new Product(101, "Laptop", 50000, 5);
//            Product product2 = new Product(102, "Smartphone", 30000, 10);

//            Console.WriteLine("Before Changing Discount:");
//            product1.DisplayProductDetails();
//            Console.WriteLine();
//            product2.DisplayProductDetails();

//            Console.WriteLine("\nUpdating Discount...\n");

//            Product.UpdateDiscount(15.0);

//            Console.WriteLine("\nAfter Changing Discount:");
//            product1.DisplayProductDetails();
//            Console.WriteLine();
//            product2.DisplayProductDetails();
//        }

//    }
//}
