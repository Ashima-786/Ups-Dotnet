using System;
public class Multiplication
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Multiplication table for given no:");
        int num=Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + "*" + i + " = " + (num * i));
        }
    }
}
