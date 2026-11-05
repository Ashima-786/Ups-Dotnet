
using System;
class ShapeCalculator
{
    public void CalculateArea(int side)
    {
        if (side > 0)
        {
            Console.WriteLine("Square Area: " + (side * side));
        }
        else
        {
            Console.WriteLine("Invalid side");
        }
    }
    public void CalculateArea(int length, int width)
    {
        if (length > 0 && width > 0)
        {
            Console.WriteLine("Rectangle Area: " + (length * width));
        }
        else
        {
            Console.WriteLine("Invalid dimensions");
        }
    }
    public void CalculateArea(double radius)
    {
        if (radius > 0)
        {
            Console.WriteLine("Circle Area: " + (3.14 *radius*radius));
        }
        else
        {
            Console.WriteLine("Invalid radius");
        }
    }
    public void CalculateArea(int baseValue, int height, string shape)
    {
        if (baseValue > 0&&height > 0)
        {
            Console.WriteLine("Triangle Area: " + (0.5 * baseValue * height));
        }
        else{
            Console.WriteLine("Invalid dimensions");
        }
    }
}

public class Sci_calc
{
    public static void Main(string[] args)
    {
        ShapeCalculator obj = new ShapeCalculator();
        obj.CalculateArea(10);
        obj.CalculateArea(20, 10);
        obj.CalculateArea(20.0);
        obj.CalculateArea(20, 34, "Triangle");
    }
}
