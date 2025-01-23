/* using System;

class DayOfWeek
{
    static void Main(string[] args)
    {
        // Parse command-line arguments
		Console.Write("enter month");
        int m = int.Parse(Console.ReadLine());  // Month
		
		Console.Write("enter day");
        int d = int.Parse(Console.ReadLine());  // Day
		
		Console.Write("enter year");
        int y = int.Parse(Console.ReadLine());  // Year

        // Apply the given formula
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + 31 * m0 / 12) % 7;

        // Array with day names
        string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        // Print the day of the week
        Console.WriteLine(daysOfWeek[d0]);
    }
}
 */