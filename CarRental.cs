//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2feb
//{
//    internal class CarRental
//    {
        
//        // Properties
//        private string CustomerName { get; set; }
//        private string CarModel { get; set; }
//        private int RentalDays { get; set; }
//        private double DailyRate { get; set; }

//        // Constructor
//        public CarRental(string customerName, string carModel, int rentalDays, double dailyRate)
//        {
//            CustomerName = customerName;
//            CarModel = carModel;
//            RentalDays = rentalDays;
//            DailyRate = dailyRate;
//        }

//        // Method to Calculate Total Cost
//        public double CalculateTotalCost()
//        {
//            return RentalDays * DailyRate;
//        }

//        public void Display()
//        {
//            Console.WriteLine($"Customer: {CustomerName}, Car Model: {CarModel}, Rental Days: {RentalDays}, Total Cost: ${CalculateTotalCost()}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            CarRental rental1 = new CarRental("John Doe", "Toyota Camry", 5, 40.0);
//            rental1.Display();
//        }

//    }
//}
