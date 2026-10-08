using System;
public class Calcstr
{
    public static void Main()
    {
        Console.WriteLine("Enter X value:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Y value:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Operation :");
        string choice = Console.ReadLine()??""; 
        int result = 0;
        switch(choice)
        {
            case "add":
                result = x + y;
                break;
            case "sub":
                result = x - y;
                break;
            case "mul":
                result = x * y;
                break;
            case "div":
                result = x / y;
                break;

            default:
                Console.WriteLine("Wrong operation entered! Please type add, sub, mul, or div.");
                        return;
        }

        Console.WriteLine("The result is: " + result);
    }
}
