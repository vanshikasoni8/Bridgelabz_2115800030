/*  using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        int result = CompareStringsLexicographically(str1, str2);

        if (result < 0)
            Console.WriteLine($"\"{str1}\" comes before \"{str2}\" in lexicographical order.");
        else if (result > 0)
            Console.WriteLine($"\"{str1}\" comes after \"{str2}\" in lexicographical order.");
        else
            Console.WriteLine($"\"{str1}\" and \"{str2}\" are equal.");
    }

    static int CompareStringsLexicographically(string str1, string str2)
    {
        int minLength = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] < str2[i])
                return -1; // str1 comes before str2
            if (str1[i] > str2[i])
                return 1;  // str1 comes after str2
        }

        // If all characters are equal, compare lengths
        if (str1.Length < str2.Length)
            return -1; // str1 is a prefix of str2
        if (str1.Length > str2.Length)
            return 1;  // str2 is a prefix of str1

        return 0; // Both strings are equal
    }
}
  */