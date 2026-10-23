using System;
public class BMI
{
    public static void Main(string[] args)
    {
        double weight = 60, height = 1.65;
        double bmi = weight / Math.Pow(height, 2);
        Console.WriteLine("BMI = " + Math.Round(bmi, 2));
    }
}
