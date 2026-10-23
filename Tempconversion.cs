using System;
public class Tempconversion
{
    public static void Main(string[] args)
    {
        double c = 25;
        double f = Math.Round((c * 9.0 / 5.0) + 32);
        Console.WriteLine("Fahrenheit = " + f);
    }
}
