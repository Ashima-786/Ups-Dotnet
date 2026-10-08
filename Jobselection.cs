using System;
class Jobselection
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Aptitude percentage: ");
        double apti = Convert.ToDouble(Console.ReadLine());
        if (apti > 70)
        {
            Console.WriteLine("Eligible for Technical Interview");
            Console.Write("Enter Technical Interview percentage: ");
            double tech = Convert.ToDouble(Console.ReadLine());
            if (tech > 80)
            {
                Console.WriteLine("Eligible for HR Interview");
                Console.Write("Enter HR percentage: ");
                double hr = Convert.ToDouble(Console.ReadLine());
                if (hr > 80)
                {
                    Console.WriteLine("Eligible to fix Salary");
                    Console.Write("Enter Total Marks out of 300: ");
                    int total = Convert.ToInt32(Console.ReadLine());
                    if (total >= 280 && total <= 300)
                    {
                        Console.WriteLine("Salary = Rs.25000");
                    }
                    else if (total >= 250 && total < 280)
                    {
                        Console.WriteLine("Salary = Rs.20000");
                    }
                    else
                    {
                        Console.WriteLine("Salary = Rs.15000");
                    }
                }
                else
                {
                    Console.WriteLine("Not eligible to fix Salary");
                }
            }
            else
            {
                Console.WriteLine("Not eligible for HR Interview");
            }
        }
        else
        {
            Console.WriteLine("Not eligible for Technical Interview");
        }
    }
}
