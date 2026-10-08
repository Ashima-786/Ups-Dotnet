using System;

public class Calcschr
{
    public static void Main()
    {
        Console.WriteLine("Enter X value:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Y value:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Operation:");
        char choice = Convert.ToChar(Console.ReadLine() ?? " "); 
        int result = 0;
        switch (char.ToLower(choice))
        {
            case 'a':
                result = x + y;
                break;
            case 's':
                result = x - y;
                break;
            case 'm':
                result = x * y;
                break;
            case 'd':
                if (y == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                    return;
                }
                result = x / y;
                break;

            default:
                Console.WriteLine("Wrong operation entered! Please type a, s, m, or d.");
                return;
        }
        Console.WriteLine("The result is: " + result);
    }
}
