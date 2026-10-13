using System;

public class Sequence1234
{
    public static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int space = 1; space < i; space++)
            {
                Console.Write("  "); 
            }
            for (int j = i; j <= 5; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
