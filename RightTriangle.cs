using System;

public class RightTriangle
{
    public static void Main(string[] args) 
    {
        int rows = 4;
        for (int i = 1; i <= rows; i++) 
        {
            for (int k = rows-i; k>0 ; k--) 
            {
                Console.Write("-");
            }
            for (int j = 1; j <= i; j++) 
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}

