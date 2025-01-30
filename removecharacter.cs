/* using System;

class RCharacter
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.Write("Enter the character to remove: ");
        char charToRemove = Console.ReadKey().KeyChar; // Read a single character
        Console.WriteLine(); // Move to the next line

        string modifiedString = RemoveCharacter(input, charToRemove);
        Console.WriteLine($"Modified String: \"{modifiedString}\"");
    }

    static string RemoveCharacter(string input, char charToRemove)
    {
        string result = "";
        
        foreach (char c in input)
        {
            if (c != charToRemove) // Keep only characters that are not the specified one
                result += c;
        }

        return result;
    }
}
 */