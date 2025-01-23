using System;

class Calculator
{
    static void Main()
    {
        // Declare variables
        double first, second;
        string op;

        // Get input values from the user
        Console.Write("Enter first number: ");
        first = double.Parse(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        op = Console.ReadLine();

        Console.Write("Enter second number: ");
        second = double.Parse(Console.ReadLine());

        // Perform the operation based on the operator using switch...case
        switch (op)
        {
            case "+":
                Console.WriteLine($"Result: {first + second}");
                break;
            case "-":
                Console.WriteLine($"Result: {first - second}");
                break;
            case "*":
                Console.WriteLine($"Result: {first * second}");
                break;
            case "/":
                // Check if second number is 0 to avoid division by zero
                if (second != 0)
                {
                    Console.WriteLine($"Result: {first / second}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
