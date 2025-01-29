/* using System;


class Array
{
    static void Main()
    {
        // Define an array to store up to 10 elements of type double
        double[] numbers = new double[10];
        double total = 0.0; // Variable to store the total
        int index = 0; // Index variable for the array


        Console.WriteLine("Enter numbers Enter 0 or a negative number to stop:");


        while (true)
        {
            Console.Write($"Enter number {index + 1}: ");
            string input = Console.ReadLine();


            if (double.TryParse(input, out double value))
            {
                if (value <= 0 || index == 10)
                {
                    break; // Stop the loop if value is 0, negative, or array limit reached
                }


                numbers[index] = value; // Store the value in the array
                index++; // Increment the index
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }


        // Calculate the total
        for (int i = 0; i < index; i++)
        {
            total += numbers[i];
        }


        // Display the numbers and the total
        Console.WriteLine("\nThe following numbers:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
        }


        Console.WriteLine($"\nTotal: {total}");
    }
}
/*  */ 