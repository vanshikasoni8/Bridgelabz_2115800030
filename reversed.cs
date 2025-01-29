/* using System;


class reverse
{
    static void Main()
    {
        // Take user input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());


        // Store the digits of the number in an array
        int temp = number;
        int count = 0;
       
        // Find the count of digits
        while (temp != 0)
        {
            count++;
            temp /= 10; // Remove the last digit
        }


        // Create an array to store the digits
        int[] digits = new int[count];


        // Store the digits in the array
        temp = number;
        for (int i = 0; i < count; i++)
        {
            digits[i] = temp % 10;  // Get the last digit
            temp /= 10;  // Remove the last digit
        }


        // Now, reverse the number using the digits array
        int reversedNumber = 0;
       
        // Build the reversed number
        for (int i = 0; i < count; i++)
        {
            reversedNumber = reversedNumber * 10 + digits[i];
        }


        // Display the reversed number
        Console.WriteLine($"The reversed number is: {reversedNumber}");
    }
}
 */