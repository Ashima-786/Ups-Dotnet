using System;
public class Longest_word
{
    public static void Main(string[] args)
    {
        Console.Write("Enter sentence: ");
        string s = Console.ReadLine();
        string[] words = s.Split(' ');
        string longest = "";
        foreach (string word in words)
        {
            if (word.Length > longest.Length)
                longest = word;
        }
        Console.WriteLine("Longest word = " + longest);
    }
}
