using System;

public class Pattern2
{
    public static void Main()
    {
        for (int i = 9; i >= 1; i -= 2)
        {
            for (int j = 9; j >= i; j -= 2)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
