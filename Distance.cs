/* using System;


class Distance
{
    static void Main()
    {        
        // Take user input for distance in feet
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = double.Parse(Console.ReadLine());


        // Convert feet to yards (1 yard = 3 feet)
        double distanceInYards = distanceInFeet / 3;


        // Convert feet to miles (1 mile = 1760 yards, so 1 mile = 1760 * 3 feet)
        double distanceInMiles = distanceInFeet / (1760 * 3);


        // Display the results
        Console.WriteLine($"The distance in yards is {distanceInYards} yards.");
        Console.WriteLine($"The distance in miles is {distanceInMiles} miles.");
    }
}
 */