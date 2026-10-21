using System;
public class OddSumArr
{
    public static void Main(string[] args)
    {
        int size = 5;
        int[] arr = new int[size];
        
        Console.WriteLine("Enter the numbers:"); 
        int sum = 0;
        for (int z = 0; z < arr.Length; z++)
        {
            arr[z] = Convert.ToInt32(Console.ReadLine());
        }
        for (int z = 0; z < arr.Length; z++)
        {
            if (arr[z] % 2 != 0) 
            {
                sum = sum + arr[z];
            }
        }
        Console.WriteLine("Sum of odd numbers: " + sum);
    }
}
