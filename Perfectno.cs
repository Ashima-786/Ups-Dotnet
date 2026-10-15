using System;
public class PerfectNumbers
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Perfect numbers between 1 and 100 are:");
        for (int num = 1; num <= 100; num++)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i; 
                }
            }
            if (sum == num && num != 0)
            {
                Console.WriteLine(num);
            }
        }
    }
}
