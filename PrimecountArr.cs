using System;
public class PrimeCountArr
{
    public static void Main(string[] args)
    {
        int size = 5;
        int[] arr = new int[size];
        int primeCount = 0; 
        Console.WriteLine("Enter the numbers:");
        for (int z = 0; z < arr.Length; z++)
        {
            arr[z] = Convert.ToInt32(Console.ReadLine());
        }
        for (int z = 0; z < arr.Length; z++)
        {
            int count = 0;
            int n = arr[z];
            if (n <= 1)
            {
                continue; 
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                primeCount++; 
            }
        }
        Console.WriteLine("Total prime numbers: " + primeCount);
    }
}
