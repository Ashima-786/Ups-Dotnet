using System;
public class Prime_noarr
{
    public static void Main(String[] args)
    {
        int size = 5;
        int[] arr = new int[size];
        Console.WriteLine("Enter the size of the numbers:"+size);
        for (int z = 0; z < arr.Length; z++)
        {
            arr[z] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\n Results ");
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
                Console.WriteLine(n + " is a prime number");
            }
            else
            {
                Console.WriteLine(n + " is a composite number");
            }
        }
    }
}
