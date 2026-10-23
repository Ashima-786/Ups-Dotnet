using System;
public class Random_circle_area
{
    public static void Main(string[] args)
    {
        Random r = new Random();
        int radius = r.Next(1, 11);
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("Radius = " + radius);
        Console.WriteLine("Area = " + Math.Round(area, 2));
    }
}
