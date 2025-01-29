/* using System;


class tallest
{
    static void Main()
    {
        // Arrays to store age and height of 3 friends
        int[] age = new int[3];
        double[] height = new double[3];


        // Input for the 3 friends' age and height
        for (int i = 0; i < 3; i++)
        {
            string friendName = i switch
            {
                0 => "Amar",
                1 => "Akbar",
                2 => "Anthony",
                _ => ""
            };


            Console.WriteLine($"Enter details for {friendName}:");


            // Input age
            Console.Write("Enter age: ");
            age[i] = int.Parse(Console.ReadLine());


            // Input height
            Console.Write("Enter height (in meters): ");
            height[i] = double.Parse(Console.ReadLine());
        }


        // Find the youngest friend
        int youngestIndex = 0;
        for (int i = 1; i < 3; i++)
        {
            if (age[i] < age[youngestIndex])
            {
                youngestIndex = i;
            }
        }


        // Find the tallest friend
        int tallestIndex = 0;
        for (int i = 1; i < 3; i++)
        {
            if (height[i] > height[tallestIndex])
            {
                tallestIndex = i;
            }
        }


        // Output the youngest and tallest friend
        string youngestFriend = youngestIndex switch
        {
            0 => "Amar",
            1 => "Akbar",
            2 => "Anthony",
            _ => ""
        };


        string tallestFriend = tallestIndex switch
        {
            0 => "Amar",
            1 => "Akbar",
            2 => "Anthony",
            _ => ""
        };


        Console.WriteLine($"\nThe youngest friend is {youngestFriend}, age {age[youngestIndex]}.");
        Console.WriteLine($"The tallest friend is {tallestFriend}, height {height[tallestIndex]} meters.");
    }
}
 */