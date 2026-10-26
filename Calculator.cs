using System;
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
    public string Add(string a, string b)
    {
        return a + b;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        Console.WriteLine("Integer Addition ");
        Console.Write("Enter first integer: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Result: " + calc.Add(intA,intB));
        Console.WriteLine(); 
        Console.WriteLine("Double Addition");
        Console.Write("Enter first double: ");
        double doubleA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second double: ");
        double doubleB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Result: " + calc.Add(doubleA, doubleB));
        Console.WriteLine();
        Console.WriteLine("String Concatenation");
        Console.Write("Enter first string: ");
        string stringA = Console.ReadLine();
        Console.Write("Enter second string: ");
        string stringB = Console.ReadLine();
        Console.WriteLine("Result: " + calc.Add(stringA, stringB));
    }
}
