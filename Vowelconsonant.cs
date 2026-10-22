using System;
using System.Text.RegularExpressions; 
public class Vowelconsonant
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine().ToLower();
        int vowels = 0, consonants = 0;
        foreach (char ch in s)
        {
            if ("aeiou".Contains(ch))
                vowels++;
            else if (char.IsLetter(ch))
                consonants++;
        }
        Console.WriteLine("Vowels = " + vowels);
        Console.WriteLine("Consonants = " + consonants);
    }
}
