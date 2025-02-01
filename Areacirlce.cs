//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _31jan
//{
//    internal class Areacirlce
//    {
//        private double radius;
        
//        public double Radius
//        {
//            get { return radius; }
//            set
//            {
//                if (value < 0)
//                {
//                    throw new ArgumentException("Radius cannot be negative");

//                }
//                radius = value;
//            }
//        }

//        public Areacirlce(double radius)
//        {
//            this.radius = radius;

//        }
//        public double CalculateArea()
//        {
//            return Math.PI * radius * radius;
//        }
//        public double calculatecircumference()
//        {
//            return 2 * Math.PI * radius;
//        }
//        public void displaydetails()
//        {
//            Console.WriteLine($"radius : {radius}");
//            Console.WriteLine($"area: {CalculateArea()}");
//            Console.WriteLine($"Circumference: {calculatecircumference()}");

//        }
//        static void Main()
//        {
//            try
//            {
//                Areacirlce circle1 = new Areacirlce(5);
//                circle1.displaydetails();

//                Areacirlce circle2 = new Areacirlce(10);
//                circle2.displaydetails();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error: {ex.Message}");

//            }
//        }

//    }
//}
