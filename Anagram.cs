using System;
public class Anagram
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine().ToLower();
        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine().ToLower();
        char[] a = s1.ToCharArray();
        char[] b = s2.ToCharArray();
        Array.Sort(a);
        Array.Sort(b);
        if (new string(a) == new string(b))
            Console.WriteLine("Anagrams");
        else
            Console.WriteLine("Not Anagrams");
    }
}
