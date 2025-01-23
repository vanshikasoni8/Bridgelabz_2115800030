/* using System;

class SumOfNNaturalNumbers
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");
        
        if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
        {
            int sumWithLoop = 0;
            int sumWithFormula = number * (number + 1) / 2;

            // Using a for loop to calculate the sum
            for (int i = 1; i <= number; i++)
            {
                sumWithLoop += i;
            }

            // Comparing the results
            if (sumWithLoop == sumWithFormula)
            {
                Console.WriteLine($"True, the sum of the first {number} natural numbers is {sumWithFormula} (verified with both formula and loop).");
            }
            else
            {
                Console.WriteLine("False, the sums do not match.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a positive integer.");
        }
    }
} */