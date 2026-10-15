using System;
class Primecomposite
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }
        if (count == 2)
        {
            Console.WriteLine("It is a PRIME number.");
        }
        else
        {
            Console.WriteLine("It is a Composite number.");
        }
    }
}
