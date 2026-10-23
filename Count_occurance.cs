using System;
public class Count_occurance
{
    public static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();
        Console.Write("Enter substring: ");
        string sub = Console.ReadLine();
        int count = 0;
        for (int i = 0; i <= s.Length - sub.Length; i++)
        {
            if (s.Substring(i, sub.Length) == sub)
                count++;
        }

        Console.WriteLine("Count = " + count);
    }
}
