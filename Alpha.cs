using System;

class alpha
{
    static void Main(String[] args)
    {
        int height = 7;
        int width = 7;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (((j == 0 || j == width - 1) && i != 0) || 
                    (i == 0 && j > 0 && j < width - 1) || 
                    (i == height / 2))
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
