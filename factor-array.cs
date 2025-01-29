/* using System;


class factors
{
    static void Main()
    {
        // user input for the number
        Console.Write("Enter a natural number to find its factors: ");
        string input = Console.ReadLine();


        if (int.TryParse(input, out int number) && number > 0)
        {
            // Initialize variables
            int maxFactor = 10;
            int[] factors = new int[maxFactor];
            int index = 0;


            // Find factors of the number
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (index == maxFactor)
                    {
                        // Resize the array if needed
                        maxFactor *= 2;
                        int[] temp = new int[maxFactor];
                        Array.Copy(factors, temp, factors.Length);
                        factors = temp;
                    }
                    factors[index++] = i;
                }
            }


            // Display the factors
            Console.WriteLine($"\nFactors of {number}:");
            for (int i = 0; i < index; i++)
            {
                Console.Write(factors[i] + " ");
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
 */