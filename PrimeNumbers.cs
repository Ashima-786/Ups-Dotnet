using System;
public class PrimeNumbers
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Prime numbers from 1 to 100:");
        for (int num = 1; num <= 100; num++)
        {
            int count = 0;
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 1)
            {
                Console.Write(num + " ");
            }
        }
    }
}
