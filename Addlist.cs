using System;
using System.Collections.Generic;

namespace Collection
{
    internal class Addlist
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the size of the list:");
            int n = Convert.ToInt32(Console.ReadLine());

            HashSet<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the element:");
                int element = Convert.ToInt32(Console.ReadLine());

                numbers.Add(element);
            }

            Console.WriteLine("Elements in the list:");

            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
