using System;
public interface IcalA
{
    double Add(double a, double b);
    double Sub(double a, double b);
}
public interface IcalB
{
    double Mul(double a, double b);
    double Div(double a, double b);
}
public class Calculator : IcalA, IcalB
{
    public double Add(double a, double b)
    {
        return a + b;
    }
    public double Sub(double a, double b)
    {
        return a - b;
    }
    public double Mul(double a, double b)
    {
        return a * b;
    }
    public double Div(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Invalid: Division by zero.");
            return 0;
        }
        return a / b;
    }
}
public class Calcul_interface
{
    public static void Main(string[] args) 
    { 
        Calculator myCalc = new Calculator(); 
        double num1 = 15; 
        double num2 = 3; 
        
        Console.WriteLine("Addition: " + num1 + " + " + num2 + " = " + myCalc.Add(num1, num2)); 
        Console.WriteLine("Subtraction: " + num1 + " - " + num2 + " = " + myCalc.Sub(num1, num2)); 
        Console.WriteLine("Multiplication: " + num1 + " * " + num2 + " = " + myCalc.Mul(num1, num2)); 
        Console.WriteLine("Division: " + num1 + " / " + num2 + " = " + myCalc.Div(num1, num2)); 
    } 
}
