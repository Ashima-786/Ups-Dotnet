using System;
public class Calcvar
{
    public static void Main()
    {
        Console.WriteLine("Enter X value:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Y value:");
        int y = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Enter Operation (1=Add, 2=Sub, 3=Mult, 4=Div):");
        int choice = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        switch(choice)
        {
            case 1:
                result = x + y;
                break;
            case 2:
                result = x - y;
                break;
            case 3:
                result = x * y;
                break;
            case 4:
                result = x / y;
                break;
        }
        Console.WriteLine("The result is: " + result);
    }
}
