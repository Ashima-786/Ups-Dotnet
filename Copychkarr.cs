
using System;
public class Copychkarr
{
    public static void Main(string[] args)
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        int[] b = new int[n];
        Console.WriteLine("Enter first array elements:");
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            b[i] = a[i];
        }
        Console.WriteLine("Copied array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(b[i] + " ");
        }
        Console.WriteLine("\nEnter second array elements to compare:");
        int[] c = new int[n];
        for (int i = 0; i < n; i++)
        {
            c[i] = Convert.ToInt32(Console.ReadLine());
        }
        int i1;
        for (i1 = 0; i1 < n; i1++)
        {
            if (b[i1] != c[i1])
                break;
        }
        if (i1 == n)
            Console.WriteLine("Both arrays are similar");
        else
            Console.WriteLine("Both arrays are different");
    }
}
