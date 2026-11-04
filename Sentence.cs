/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;
static class StringExtensions
{
    public static int CountWords(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }

        string[] words = text.Split(
            new char[] { ' ', '.', ',', '!', '?' },
            StringSplitOptions.RemoveEmptyEntries
        );

        return words.Length;
    }

    public static int CountVowels(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }

        int vowelCount = 0;
        string vowels = "aeiouAEIOU";

        foreach (char c in text)
        {
            if (vowels.Contains(c))
            {
                vowelCount++;
            }
        }

        return vowelCount;
    }
    public static int CountConsonants(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }
        int consonantCount = 0;
        string vowels = "aeiouAEIOU";
        foreach (char c in text)
        {
            if (char.IsLetter(c) && !vowels.Contains(c))
            {
                consonantCount++;
            }
        }

        return consonantCount;
    }
}

class Sentence
{
    static void Main()
    {
        string name = "Hii i am Ashima.i did my schoolings in ceoa!nice meeting you.Wow what a pleasant surprise!!!";

        int wordCount = name.CountWords();
        int vowelCount = name.CountVowels();
        int consonantCount = name.CountConsonants();

        Console.WriteLine("Text: " + name);
        Console.WriteLine("Word Count: " + wordCount);
        Console.WriteLine("Vowel Count: " + vowelCount);
        Console.WriteLine("Consonant Count: " + consonantCount);
    }
}
