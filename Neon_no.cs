using System;
public class Neon_no
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a no: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sq = n * n; 
        int sum = 0;
        while (sq > 0)
        {
            int digit = sq % 10; 
            sum += digit;        
            sq = sq / 10;       
        }
        if (n == sum)
        {
            Console.WriteLine(n + " is a Neon no");
        }
        else
        {
            Console.WriteLine(n + " is not a Neon no");
        }
    }
}
