/* using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter a number greater than 1: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number > 1)
        {
            bool isPrime = true;

            // Check divisors from 2 to the square root of the number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false; // Number is divisible by i, not a prime
                    break;
                }
            }

            // Output the result
            if (isPrime)
            {
                Console.WriteLine($"{number} is a Prime Number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a Prime Number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter an integer greater than 1.");
        }
    }
}
 */