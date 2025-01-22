/* using System;

class Program
{
    static void Main()
    {
        //input for the first number
        Console.Write("Enter the first number (number1): ");
        int number1 = int.Parse(Console.ReadLine());

        //input for the second number
        Console.Write("Enter the second number (number2): ");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nBefore swapping: number1 = {number1}, number2 = {number2}");

        // Swap the numbers
        SwapNumbers(ref number1, ref number2);

        // Display the swapped numbers
        Console.WriteLine($"After swapping: number1 = {number1}, number2 = {number2}");
    }

    // Method to swap two numbers using ref
    static void SwapNumbers(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
}
 */