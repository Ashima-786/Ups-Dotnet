using System;

public class ReversePattern
{
    public static void Main(string[] args) 
    {
        int rows = 4;
        for (int i = rows; i >= 1; i--) 
        {
            for (int j = 1; j <= i; j++) 
            {
                Console.Write(j);
            }
            for (int k = 1; k <= (rows - i); k++) 
            {
                Console.Write("-"); 
            }
            Console.WriteLine();
        }
    }
}
