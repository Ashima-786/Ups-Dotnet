using System;
public class Hollow_triangle
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                if (i == 3 || i + j == 4 || j - i == 2)
                {
                    Console.Write("*");
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
