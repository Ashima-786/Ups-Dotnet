using System;
public class Armstrong_noarr
{
    public static void Main(string[] args)
    {
        int size = 5;
        int[] arr = new int[size];
        Console.WriteLine("Enter 5 numbers:");
        for (int z = 0; z < arr.Length; z++)
        {
            arr[z] = Convert.ToInt32(Console.ReadLine());
        }
        for (int z = 0; z < arr.Length; z++)
        {
            int n = arr[z];
            int temp = n;
            int digits = n.ToString().Length;
            double sum = 0;
            while (temp > 0)
            {
                int r = temp % 10;
                sum = sum + Math.Pow(r, digits);
                temp = temp / 10;
            }
            if (sum == n)
            {
                Console.WriteLine(n + " is an Armstrong number");
            }
            else
            {
                Console.WriteLine(n + " is not an Armstrong number");
            }
        }
    }
}
