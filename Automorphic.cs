using System;
public class Automorphic
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int square = n * n;
        if (square.ToString().EndsWith(n.ToString()))
            Console.WriteLine("Automorphic Number");
        else
            Console.WriteLine("Not Automorphic Number");
    }
}
