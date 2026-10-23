using System;
public class Distance_twopt
{
    public static void Main(string[] args)
    {
        double x1 = 0, y1 = 0;
        double x2 = 3, y2 = 4;
        double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine("Distance = " + d);
    }
}
