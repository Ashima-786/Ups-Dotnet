using System;
public class Digitcal
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int temp = num;
        int count = 0;
        int sum = 0;
        int product = (temp == 0) ? 0 : 1; 
        if (temp == 0)
        {
            count = 1;
        }
        while (temp > 0)
        {
            int digit = temp % 10;
            
            count++;          
            sum += digit;     
            product *= digit; 
            temp /= 10;
        }
        Console.WriteLine("Total Digits: " + count);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Product: " + product);
    }
}
