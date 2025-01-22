using System;


class Poundstokg
{
    static void Main()
    {
        // Prompt the user to enter weight in pounds
        Console.Write("Enter weight in pounds: ");
        double weightInPounds = double.Parse(Console.ReadLine());


        // Convert pounds to kilograms (1 pound = 2.2 kg)
        double weightInKilograms = ConvertPoundsToKilograms(weightInPounds);


        // Display the result
        Console.WriteLine($"The weight of the person in pounds is {weightInPounds} and in kilograms is {weightInKilograms:F2}");
    }


    // Method to convert pounds to kilograms
    static double ConvertPoundsToKilograms(double pounds)
    {
        return pounds / 2.2;
    }
}
