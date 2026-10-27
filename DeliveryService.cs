#here i used 2.5 and 4.5 as mandatory mass cal
using System;
public class DeliveryService
{
    public double CalculateDeliveryCharge(double distance)
    {
        return distance*2.5;
    }
    public double CalculateDeliveryCharge(double distance, double weight)
    {
        return (distance*2.5)+(weight*4.5);
    }
    public double CalculateDeliveryCharge(double distance, double weight, bool isExpress)
    {
        double total = (distance * 2.5)+(weight * 4.5);
        if (isExpress)
        {
            return total + 75.0;
        }
        return total;
    }
}
public class Hii
{
    public static void Main(string[] args)
    {
         DeliveryService service = new DeliveryService();
         Console.WriteLine("Enter distance:");
         double distance = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter weight:");
         double weight = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Is Express (true/false):");
         bool isExpress = Convert.ToBoolean(Console.ReadLine());
         Console.WriteLine("Distance Only: " + service.CalculateDeliveryCharge(distance));
         Console.WriteLine("With Weight: " + service.CalculateDeliveryCharge(distance, weight));
         Console.WriteLine("With Express: " + service.CalculateDeliveryCharge(distance, weight, isExpress));
    }
}
