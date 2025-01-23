/* using System;

class LeapYearCheckLogical
{
    static void Main()
    {
        Console.Write("Enter a year (>= 1582): ");
        if (int.TryParse(Console.ReadLine(), out int year) && year >= 1582)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Enter a year greater than or equal to 1582.");
        }
    }
}
 */