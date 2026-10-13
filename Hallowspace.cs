using System;

public class Hollowspace
{
    public static void Main(string[] args)
    {
        int n = 4;

        for (int i = n; i > 0; i--)
        {
            for (int k = n - i; k > 0; k--)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                if (i == n || j == i)
                {
                    Console.Write(j);
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}
