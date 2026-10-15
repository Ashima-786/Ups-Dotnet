using System;
public class Divisorchk 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0) 
                sum += i;
        }
        if (sum > num){
            Console.WriteLine("Abundant");
        }
        if (sum < num) {
            Console.WriteLine("Deficient");
        }
    }
}
