using System;
public class Ascdescarr
{
    public static void Main(String[] args)
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(arr);
        Console.WriteLine("Ascending order:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Array.Reverse(arr);
        Console.WriteLine("\nDescending order:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
