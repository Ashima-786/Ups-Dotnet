using System;
public class Odd_loop
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Odd numeber between 1 and 100:");
        for(int i = 2; i <100; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}
