using System;
using System.IO;
class CreateFile
{
    static string folderPath = Directory.GetCurrentDirectory();
    static string filePath = Path.Combine(folderPath, "sample.txt");
    public static void Main(string[] args)
    {
        File.WriteAllText(filePath, "Ashima");

        string readText = File.ReadAllText(filePath);

        Console.WriteLine("File created: " + filePath);
        Console.WriteLine("File content: " + readText);
    }
}
