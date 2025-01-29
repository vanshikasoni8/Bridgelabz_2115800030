using System;


class Frequency
{
    static void Main()
    {
        // Take input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());


        // Define an array to store the frequency of each digit (0-9)
        int[] frequency = new int[10];


        // Find the digits in the number and store them in an array
        int temp = number;
        while (temp > 0)
        {
            int digit = temp % 10;  // Get the last digit
            frequency[digit]++;     // Increase the frequency of the digit
            temp /= 10;             // Remove the last digit from the number
        }


        // Display the frequency of each digit
        Console.WriteLine("\nFrequency of each digit in the number:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)  // Only print digits that appear in the number
            {
                Console.WriteLine($"Digit {i}: {frequency[i]} time(s)");
            }
        }
    }
}

