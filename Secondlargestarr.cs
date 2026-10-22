using System;
class Secondlargestarr
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
        int largest = int.MinValue;
        int secondLargest = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > largest)
            {
                secondLargest = largest;
                largest = arr[i];
            }
            else if (arr[i] > secondLargest && arr[i] != largest)
            {
                secondLargest = arr[i];
            }
        }
        if (secondLargest == int.MinValue)
        {
            Console.WriteLine("Second largest element does not exist.");
        }
        else
        {
            Console.WriteLine("Second largest element: " + secondLargest);
        }
    }
}
