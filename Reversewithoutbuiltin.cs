using System;
public class Reversewithoutbuiltin
{
    public static void Main(string[] args)
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int start = 0;
        int end = n - 1;
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
        Console.WriteLine("Reversed array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
