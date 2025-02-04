//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2feb
//{
//    internal class Circle
//    {
        
//        // Property
//        public double Radius { get; set; }

//        public Circle() : this(1.0) { }

//        // Parameterized Constructor
//        public Circle(double radius)
//        {
//            Radius = radius;
//        }

//        // Method to Calculate Area
//        public double GetArea()
//        {
//            return Math.PI * Radius * Radius;
//        }

//        // Display Method
//        public void Display()
//        {
//            Console.WriteLine($"Radius: {Radius}, Area: {GetArea()}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Using Default Constructor
//            Circle circle1 = new Circle();
//            circle1.Display();

//            // Using Parameterized Constructor
//            Circle circle2 = new Circle(5.0);
//            circle2.Display();
//        }
//    }



//}
