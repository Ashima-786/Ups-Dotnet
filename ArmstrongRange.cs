using System;
public class ArmstrongRange
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Armstrong numbers from 100 and 1000 are:");
        for (int num =100; num <= 1000; num++)
        {
            int temp = num;
            int sum = 0;
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += digit * digit * digit; 
                temp /= 10;
            }
            if (sum == num)
            {
                Console.WriteLine(num);
            }
        }
    }
}
