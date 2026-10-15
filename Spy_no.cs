using System;
public class Spy_no
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int original = n;
        int sum = 0;
        int pdt = 1;
        while (n > 0)
        {
            int digit = n % 10;
            sum += digit;
            pdt *= digit;
            n = n / 10;
        }
        if (sum == pdt)
        {
            Console.WriteLine(original + " is a spy no");
        }
        else
        {
            Console.WriteLine(original + " is not a spy no");
        }
    }
}
