/* using System;
class Height
{
    static void Main()
    {
        //input for height in centimeters
        Console.Write("Enter your height in centimeters: ");
        double heightCm = double.Parse(Console.ReadLine());


        // Convert centimeters to inches (1 inch = 2.54 cm)
        double heightInches = heightCm / 2.54;


        // Convert inches to feet and remaining inches
        int feet = (int)(heightInches / 12);
        double remainingInches = heightInches % 12;


        // Display the result
        Console.WriteLine($"Your Height in cm is {heightCm} while in feet is {feet} and inches is {remainingInches:F2}");
    }
}
 */