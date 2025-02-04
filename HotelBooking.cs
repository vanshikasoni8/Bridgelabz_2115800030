//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2feb
//{
//    internal class HotelBooking
//    {
//        private string GuestName { get; set; }
//        private string RoomType { get; set; }
//        private int Nights { get; set; }

//        // Default Constructor
//        public HotelBooking()
//        {
//            GuestName = "Unknown";
//            RoomType = "Standard";
//            Nights = 1;
//        }

//        // Parameterized Constructor
//        public HotelBooking(string guestName, string roomType, int nights)
//        {
//            GuestName = guestName;
//            RoomType = roomType;
//            Nights = nights;
//        }

//        // Copy Constructor
//        public HotelBooking(HotelBooking other)
//        {
//            GuestName = other.GuestName;
//            RoomType = other.RoomType;
//            Nights = other.Nights;
//        }

//        // Display Method
//        public void Display()
//        {
//            Console.WriteLine($"Guest: {GuestName}, Room: {RoomType}, Nights: {Nights}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Using Default Constructor
//            HotelBooking booking1 = new HotelBooking();
//            booking1.Display();

//            // Using Parameterized Constructor
//            HotelBooking booking2 = new HotelBooking("John Doe", "Deluxe", 3);
//            booking2.Display();

//            // Using Copy Constructor
//            HotelBooking booking3 = new HotelBooking(booking2);
//            booking3.Display();
//        }

//    }
//}
