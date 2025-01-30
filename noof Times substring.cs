/* using System;

class Program
{
    static void Main()
    {
        string text = "hello hello world, hello everyone";
        string substring = "hello";

        int count = CountSubstringOccurrences(text, substring);
        Console.WriteLine($"{substring} occurs {count} times in the text.");
    }

    static int CountSubstringOccurrences(string text, string substring)
    {
        if (string.IsNullOrEmpty(substring))
            return 0;

        int count = 0;
        int index = 0;

        while ((index = text.IndexOf(substring, index)) != -1)
        {
            count++;
            index += substring.Length; // Move index forward to avoid overlapping matches
        }

        return count;
    }
}
 */