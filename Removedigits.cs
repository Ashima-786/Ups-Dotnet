using System;
public class Removedigits{
    public static void Main(string[] args){
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();
        string result = "";
        foreach (char ch in s)
        {
            if (!char.IsDigit(ch))
                result += ch;
        }
        Console.WriteLine(result);
    }
}
