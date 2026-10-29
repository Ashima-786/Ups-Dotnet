using System;
using System.IO;
public class Name_WriteAll
{
    public static void Main(string[] args)
    {
        string path="name.txt";
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        File.WriteAllText("name.txt", name);
        Console.WriteLine("Done!");
    }
}
