using System;
public class Removevowel
{
    public static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();
        string res = "";
        foreach (char c in s)
        {
            if (!"aeiouAEIOU".Contains(c))
                res += c;
        }
        Console.WriteLine(res);
    }
}
