using System;
public class Sumarr
{
    static void Main(string[] args)
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        int sum = 0;
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum = sum + arr[i];
        }
        Console.WriteLine("Sum of array elements: " + sum);
    }
}
