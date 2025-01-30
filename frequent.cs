/* using System;

class Frequent
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char mostFrequentChar = FindMostFrequentCharacter(input);
        Console.WriteLine($"Most Frequent Character: '{mostFrequentChar}'");
    }

    static char FindMostFrequentCharacter(string input)
    {
        int[] freq = new int[256]; // Array to store frequency 
        int maxCount = 0;
        char mostFrequentChar = '\0';

        foreach (char c in input)
        {
            freq[c]++; // Increment frequency count

            if (freq[c] > maxCount)
            {
                maxCount = freq[c];
                mostFrequentChar = c;
            }
        }

        return mostFrequentChar;
    }
}
 */