using System;
public class Right_alphabet
{
    public static void Main(String[] args)
    {
        char x=(char)('A'-1);
        for(int i = 1; i <= 4; i++)
        {
            
            for(int j = i; j <= 4; j++)
            {
                Console.Write("  ");
            }
            for(int k = 1; k <= i; k++)
            {
                x=(char)(x+1);
                Console.Write(x+" ");
            }
            Console.WriteLine();
        }
    }
}
