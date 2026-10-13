using System;
public class Pattern7
{
    public static void Main(String[] args)
    {
        for (int i = 7; i >= 1; i -= 2)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
