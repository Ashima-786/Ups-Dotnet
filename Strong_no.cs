using System;
public class Strongno
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
            int fact = 1;
            for (int i = 1; i <= digit; i++)
            {
                fact *= i;
            }
            sum += fact;  
            temp /= 10;  
        }
        if (num == sum)
        {
            Console.WriteLine(num + " is a Strong Number");
        }
        else
        {
            Console.WriteLine(num + " is not a Strong Number");
        }
    }
}
