using System;
public class upperlowervise{
    public static void Main(string[] args){
        Console.WriteLine("Enter a string: ");
        string s = Console.ReadLine();
        string result = "";
        foreach (char ch in s)
        {
            if (char.IsUpper(ch))
                result += char.ToLower(ch);
            else if (char.IsLower(ch))
                result += char.ToUpper(ch);
            else
                result += ch;
        }

        Console.WriteLine(result);
    }
}
