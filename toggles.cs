/* using System;

class toggled
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine(); // Take input 
        
        string toggledString = ToggleCase(input);
        
        Console.WriteLine("Toggled String: " + toggledString);
    }

    static string ToggleCase(string input)
    {
        char[] result = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsUpper(input[i]))
                result[i] = char.ToLower(input[i]);
            else if (char.IsLower(input[i]))
                result[i] = char.ToUpper(input[i]);
            else
                result[i] = input[i]; 
        }

        return new string(result);
    }
}
 */