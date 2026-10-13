using System;

public class Pattern5
{
    public static void Main(String[] args)
    {
        for (int i = 3; i <= 6; i++)
        {
            for (int j = 3; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
