using System;

public class Odd_pattern
{
    public static void Main()
    {
        for (int i = 9; i >= 1; i -= 2)
        {
            for (int j = 1; j <= i; j += 2)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
