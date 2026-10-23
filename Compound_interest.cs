using System;
public class Compound_interest
{
    public static void Main(string[] args)
    {
        double p = 10000, r = 5;
        int t = 2;
        double ci = p * Math.Pow(1 + r / 100, t) - p;
        Console.WriteLine("Compound Interest = " + ci);
    }
}
