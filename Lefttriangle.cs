using System;
class Lefttriangle
{
    static void Main() 
    {
        for (int i = 0; i < 5; i++) 
        {
            for (int j = 0; j <= i; j++) 
            {
                Console.Write((char)('A' + i + j) + " ");
            }
            Console.WriteLine();
        }
    }
}
