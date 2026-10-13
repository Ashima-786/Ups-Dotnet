using System;

public class Pattern6
{
    public static void Main(String[] args)
    {
        int counter = 15;
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(counter + " ");
                counter--;
            }
            Console.WriteLine();
        }
    }
}
