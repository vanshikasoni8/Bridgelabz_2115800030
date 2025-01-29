/* using System;


class table
{
    static void Main()
    {
        // user input for the number
        Console.Write("Enter a number : ");
        string input = Console.ReadLine();


        if (int.TryParse(input, out int number))
        {
            // Define an array to store the multiplication results from 6 to 9
            int[] multiplicationResult = new int[4];


            // Calculate the multiplication table from 6 to 9
            for (int i = 6; i <= 9; i++)
            {
                multiplicationResult[i - 6] = number * i;
            }


            // Display the multiplication table
            Console.WriteLine($"\nTable of {number} (from 6 to 9):");
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"{number} * {i} = {multiplicationResult[i - 6]}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
 */