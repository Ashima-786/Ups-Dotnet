using System;
public class Quadratic_eqn
{
    public static void Main(string[] args)
    {
        double a, b, c, d, r1, r2;
        Console.Write("Enter a:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter b:");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter c: ");
        c = Convert.ToDouble(Console.ReadLine());
        d = b * b - 4 * a * c;
        if (a == 0)
        {
            Console.WriteLine("Not a quadratic equation");
        }
        else if (d >= 0)
        {
            r1 = (-b + Math.Sqrt(d)) / (2 * a);
            r2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("Root 1 = " + r1);
            Console.WriteLine("Root 2 = " + r2);
        }
        else
        {
            Console.WriteLine("Imaginary roots");
        }
    }
}
