/* using System;


class Triangle
{
    static void Main()
    {
        // Declare variables for base and height
        double baseLength, height;


        // Take user input for base and height
        Console.Write("Enter the base of the triangle (in inches): ");
        baseLength = double.Parse(Console.ReadLine());


        Console.Write("Enter the height of the triangle (in inches): ");
        height = double.Parse(Console.ReadLine());


        // Calculate the area in square inches
        double areaInInches = 0.5 * baseLength * height;


        // Convert the base and height from inches to centimeters (1 inch = 2.54 cm)
        double baseInCm = baseLength * 2.54;
        double heightInCm = height * 2.54;


        // Calculate the area in square centimeters
        double areaInCm = 0.5 * baseInCm * heightInCm;


        // Display the results
        Console.WriteLine($"The area of the triangle is {areaInInches} square inches.");
        Console.WriteLine($"The area of the triangle is {areaInCm} square centimeters.");
    }
}
 */