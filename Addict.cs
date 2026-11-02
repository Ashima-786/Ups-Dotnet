using System;
using System.Collections.Generic;
namespace Collection
{
    internal class Addict
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the size of the list:");
            int n = Convert.ToInt32(Console.ReadLine());

            Dictionary<int, int> nos = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the element:");
                int element = Convert.ToInt32(Console.ReadLine());
                nos.Add(element, i);
            }
            Console.WriteLine("\nElements in the dictionary (Key -> Value):");
            foreach (KeyValuePair<int, int> i in nos)
            {
                Console.WriteLine($"Key: {i.Key}, Value: {i.Value}");
            }
        }
    }
}
