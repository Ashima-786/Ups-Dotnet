using System;
public class Exp_growth
{
    public static void Main(string[] args)
    {
        double initial = 1000, rate = 0.05;
        int years = 10;
        double population = initial * Math.Exp(rate * years);
        Console.WriteLine("Population = " + Math.Round(population, 2));
    }
}
