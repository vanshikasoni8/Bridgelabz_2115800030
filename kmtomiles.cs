using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the distance in kilometers: ");
        double kilometers = Convert.ToDouble(Console.ReadLine());
        double miles = kilometers * 0.621371;

        Console.WriteLine("{0} kilometers is equal to {1} miles.", kilometers, miles);
    }
}
