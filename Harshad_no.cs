using System;
public class Harshad_no 
{
    public static void Main(String[] args) 
    {
        Console.WriteLine("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int originalNumber = n; 
        int sum = 0;
        while (n > 0) 
        {
            int digit = n % 10;
            sum += digit;
            n = n / 10;
        }
        if (originalNumber % sum == 0)
        {
            Console.WriteLine(originalNumber + " is divisible by its sum of digits (" + sum + ").");
        }
        else
        {
            Console.WriteLine(originalNumber + " is NOT divisible by its sum of digits (" + sum + ").");
        }
    }
}
