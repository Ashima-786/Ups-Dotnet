using System;
public class SumOfDigits
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int temp = num; 
        int sum = 0;

        while (temp > 0)
        {
            int digit = temp % 10; 
            sum += digit;          
            temp /= 10;            
        }
        Console.WriteLine("Sum of digits of " + num + " = " + sum);
    }
}
