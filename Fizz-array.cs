/* using System;


class Fizz
{
    static void Main()
    {
        // Take input from the user
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());


        // Check if the number is positive
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }


        // Create a string array to store results
        string[] results = new string[number + 1];


        // Loop through numbers from 0 to the input number
        for (int i = 0; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                results[i] = "FizzBuzz";
            else if (i % 3 == 0)
                results[i] = "Fizz";
            else if (i % 5 == 0)
                results[i] = "Buzz";
            else
                results[i] = i.ToString();
        }


        // Loop through the results array and print the output
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine($"Position {i} = {results[i]}");
        }
    }
}
 */