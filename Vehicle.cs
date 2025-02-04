//using System;

//public class Vehicle{
//    public static decimal RegistrationFee = 200.00m;
//    public string OwnerName { get; set; }
//    public string VehicleType { get; set; }

//    // Constructor 
//    public Vehicle(string ownerName, string vehicleType)
//    {
//        OwnerName = ownerName;
//        VehicleType = vehicleType;
//    }

//    // Instance method to display vehicle details
//    public void DisplayVehicleDetails()
//    {
//        Console.WriteLine($"Owner Name: {OwnerName}");
//        Console.WriteLine($"Vehicle Type: {VehicleType}");
//        Console.WriteLine($"Registration Fee: ${RegistrationFee}");
//    }

//    // Class method to update the registration fee for all vehicles
//    public static void UpdateRegistrationFee(decimal newFee)
//    {
//        RegistrationFee = newFee;
//        Console.WriteLine($"Registration fee updated to: ${RegistrationFee}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Creating vehicles
//        Vehicle vehicle1 = new Vehicle("John Doe", "Car");
//        Vehicle vehicle2 = new Vehicle("Jane Smith", "Motorcycle");

//        // Displaying details
//        vehicle1.DisplayVehicleDetails();
//        Console.WriteLine();
//        vehicle2.DisplayVehicleDetails();
//        Console.WriteLine();

//        Vehicle.UpdateRegistrationFee(250.00m);
//        vehicle1.DisplayVehicleDetails();
//        Console.WriteLine();
//        vehicle2.DisplayVehicleDetails();
//        Console.ReadLine();
//    }
    

//}

