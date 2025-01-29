/* using System;


class Football
{
    static void Main()
    {
        // Define an array to store the heights of 11 players
        double[] heights = new double[11];
        double sum = 0.0; // Variable to store the sum of heights


        Console.WriteLine("Enter the heights of 11 football players:");


        // Get input values from the user
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Enter height for player {i + 1}: ");
            string input = Console.ReadLine();


            if (double.TryParse(input, out double height))
            {
                heights[i] = height;
                sum += height; // Add height to the sum
            }
            else
            {
                Console.WriteLine("Invalid input");
                i--; // Repeat the current iteration for valid input
            }
        }


        // Calculate the mean height
        double mean = sum / heights.Length;


        // Display the mean height
        Console.WriteLine($"\nThe mean height of the football team is: {mean:F2}");
    }
}
 */