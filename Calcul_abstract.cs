using System;
public abstract class Calc 
{ 
    public abstract double add(double a, double b); 
    public abstract double sub(double a, double b); 
    
    public double mul(double a, double b) 
    { 
        return a * b; 
    } 
    public double div(double a, double b) 
    { 
        if (b == 0) 
        { 
            Console.WriteLine("Error: Division by zero."); 
            return 0; 
        } 
        return a / b; 
    } 
} 
public class SimpleCalc : Calc 
{ 
    public override double add(double a, double b) 
    { 
        return a + b; 
    } 
    
    public override double sub(double a, double b) 
    { 
        return a - b; 
    } 
} 
public class Calcul_abstract
{ 
    public static void Main(string[] args) 
    { 
        Calc myCalc = new SimpleCalc(); 
        double num1 = 15; 
        double num2 = 3; 
        Console.WriteLine("Addition: " + num1 + " + " + num2 + " = " + myCalc.add(num1, num2)); 
        Console.WriteLine("Subtraction: " + num1 + " - " + num2 + " = " + myCalc.sub(num1, num2)); 
        Console.WriteLine("Multiplication: " + num1 + " * " + num2 + " = " + myCalc.mul(num1, num2)); 
        Console.WriteLine("Division: " + num1 + " / " + num2 + " = " + myCalc.div(num1, num2)); 
    } 
}
