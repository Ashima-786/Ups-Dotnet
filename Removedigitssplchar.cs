using System;
using System.Text.RegularExpressions; 
public class RemoveDigitssplchar
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();
        string result = Regex.Replace(s, @"[^a-zA-Z0-9]", "");
        Console.WriteLine(result);
    }
}
