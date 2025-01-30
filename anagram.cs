/* using System;

class Anagram
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        if (AreAnagrams(str1, str2))
            Console.WriteLine("The two strings are anagrams.");
        else
            Console.WriteLine("The two strings are NOT anagrams.");
    }

    static bool AreAnagrams(string str1, string str2)
    {
        
        if (str1.Length != str2.Length)
            return false;

        
        char[] arr1 = str1.ToLower().ToCharArray();
        char[] arr2 = str2.ToLower().ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        // Compare sorted character arrays
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
                return false;
        }
        
        return true;
    }
}
 */