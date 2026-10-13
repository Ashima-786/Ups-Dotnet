using System;
public class Pattern_p
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                if (j == 1 || i == 1 || i == 3 || (j == 4 && i <= 3))
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  "); 
                }
            }
            Console.WriteLine();
        }
    }
}
