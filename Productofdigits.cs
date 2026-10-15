using System;
public class productofdigits 
{
    public static void Main(string[] args) 
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine("Product of digits = 0");
            return;
        }
        int product = 1; 
        while (n > 0) 
        {
            int digit = n % 10;
            product *= digit; 
            n = n / 10;
        }
        Console.WriteLine("Product of digits = " + product); 
    }
}
