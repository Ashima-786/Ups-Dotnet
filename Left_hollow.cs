using System;
public class Left_hollow
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int k = 1; k <= (i - 1); k++)
            {
                Console.Write("  ");
            }
            for (int j = i; j <= 4; j++)
            {
                if (i == 2 && j == 3)
                {
                    Console.Write("  ");
                }
                else
                {
                    char x = (char)('A' + (j - i) * 2);
                    Console.Write(x + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
