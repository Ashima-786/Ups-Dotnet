using System;

public class Copyelementsarr
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Copy(arr1, arr2, n);
        Console.WriteLine("Original array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr1[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Copied array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr2[i] + " ");
        }
        Console.WriteLine();
    }
}
