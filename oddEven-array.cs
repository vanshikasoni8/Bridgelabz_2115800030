/* using System;


class OddEven
{
    static void Main()
    {
        // User input for the range
        Console.Write("Enter a natural number: ");
        string input = Console.ReadLine();


        if (int.TryParse(input, out int number) && number > 0)
        {
            // Create arrays to store odd and even numbers
            int[] oddNumbers = new int[number / 2 + 1];
            int[] evenNumbers = new int[number / 2 + 1];
            int oddIndex = 0, evenIndex = 0;


            // Separate odd and even numbers
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers[evenIndex++] = i;
                }
                else
                {
                    oddNumbers[oddIndex++] = i;
                }
            }


            // Display the odd numbers
            Console.WriteLine("\nOdd Numbers:");
            for (int i = 0; i < oddIndex; i++)
            {
                Console.Write(oddNumbers[i] + " ");
            }


            // Display the even numbers
            Console.WriteLine("\n\nEven Numbers:");
            for (int i = 0; i < evenIndex; i++)
            {
                Console.Write(evenNumbers[i] + " ");
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
 */