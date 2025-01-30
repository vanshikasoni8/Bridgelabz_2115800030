using System;

class Replace
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter the word to replace: ");
        string wordToReplace = Console.ReadLine();

        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();

        string modifiedSentence = ReplaceWord(sentence, wordToReplace, newWord);
        Console.WriteLine("Modified Sentence: " + modifiedSentence);
    }

    static string ReplaceWord(string sentence, string wordToReplace, string newWord)
    {
        string result = "";
        string currentWord = "";
        
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ')
            {
                currentWord += sentence[i]; 
            }
            else
            {
                if (currentWord == wordToReplace)
                    result += newWord + " ";
                else
                    result += currentWord + " ";
                
                currentWord = ""; // Reset for the next word
            }
        }

        
        if (currentWord == wordToReplace)
            result += newWord;
        else
            result += currentWord;

        return result;
    }
}
