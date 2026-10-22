using System;
public class Countfreq
{
    public static void Main(string[] args)
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        bool[] visited = new bool[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Frequency of each element:");
        for (int i = 0; i < n; i++)
        {
            if (visited[i])
            {
                continue;
            }
            int count = 1;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    visited[j] = true;
                }
            }
            Console.WriteLine(arr[i] + " occurs " + count + " times");
        }
    }
}
