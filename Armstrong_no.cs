using System;
public class Armstrong_no
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int temp = num, sum = 0, digits = num.ToString().Length;
        while (temp > 0)
        {
            int d = temp % 10;
            sum += (int)Math.Pow(d, digits);
            temp /= 10;
        }
        if (num == sum)
        {
            Console.WriteLine(num + " is an Armstrong Number");
        }
        else
        {
            Console.WriteLine(num + " is not an Armstrong Number");
        }
    } 
}
