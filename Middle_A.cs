using System;
public class Middle_A
{
    public static void Main(String[] args)
    {
        int rows = 5; 
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < (rows - i - 1) * 2; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write((char)('A' + j));
                if (i > 0 || j < i) Console.Write(" ");
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write((char)('A' + j));
                if (j > 0) Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
