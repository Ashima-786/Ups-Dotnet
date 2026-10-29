using System;
public class Smartcalc{
    public static void Main(string[] args){
        Console.WriteLine("=== Smart Calculator ===");
        try
        {
            Console.Write("Enter first number: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter second number: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            switch (op)
            {
                case '+': 
                    result = n1 + n2; 
                    break;
                case '-': 
                    result = n1 - n2; 
                    break;
                case '*':
                    result = n1 * n2; 
                    break;
                case '/':
                    if (n2 == 0) 
                    {
                        throw new DivideByZeroException();
                    }
                    result = n1 / n2; 
                    break;
                default: 
                    Console.WriteLine("Error: Invalid operator entered.");
                    return;
            }
            Console.WriteLine("Result: " + n1 + " " + op + " " + n2 +"=" +result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input format enter numbers");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error:Division by zero is not allowed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
