using System;
using System.IO;
public class Name_ReadLine
{
    public static void Main(string[] args)
    {
        string path="name.txt";
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        File.WriteAllText(path, name);
        string area=File.ReadAllText("name.txt");
        Console.WriteLine("Done!");
        Console.WriteLine(area);
    }
}
