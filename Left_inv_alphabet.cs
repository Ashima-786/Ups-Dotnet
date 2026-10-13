using System;
public class Left_inv_alphabet
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int k=1;k<=(i-1);k++)
            {
                Console.Write("  ");
            }
            for (int j = i; j <= 4; j++)
            {
                char x = (char)('A'+(j-i)*2);
                Console.Write(x+" ");
            }
            
            Console.WriteLine();
        }
    }
}
