using System;
public class R_pattern
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++) 
        {
            for (int j = 1; j <= 4; j++) 
            {
                if (j == 1 || i == 1 || i == 3 || (j == 4 && i <= 3) || (i == 4 && j == 3) || (i == 5 && j == 4))
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
