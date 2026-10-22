using System;
public class Kthsmlar_arr
{
    public static void Main(string[] args)
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Invalid array size");
            return;
        }
        int[] arr = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Enter K value: ");
        int k = Convert.ToInt32(Console.ReadLine());
        if (k < 1 || k > n)
        {
            Console.WriteLine("Invalid K value");
            return;
        }
        Array.Sort(arr);
        Console.WriteLine("Sorted array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Kth smallest element: " + arr[k - 1]);
        Console.WriteLine("Kth largest element: " + arr[n - k]);
    }
}
