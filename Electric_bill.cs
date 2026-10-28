using System;
public class Electric_bill
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of customers: ");
        int customers = Convert.ToInt32(Console.ReadLine());
        double totalRevenue = 0;
        for (int i = 1; i <= customers; i++)
        {
            Console.WriteLine("\nCustomer " + i);
            Console.Write("Enter customer ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();
            Console.Write("Enter units consumed: ");
            int units = Convert.ToInt32(Console.ReadLine());
            double bill = 0;
            if (units <= 100)
            {
                bill = units * 1.5;
            }
            else if (units <= 200)
            {
                bill = 100 * 1.5 + (units - 100) * 2.5;
            }
            else
            {
                bill = 100 * 1.5 + 100 * 2.5+(units - 200)*4;
            }
            bill = bill + 50;
            if (bill > 1000)
            {
                bill = bill + bill * 0.05;
            }
            Console.WriteLine("ELECTRICITY BILL");
            Console.WriteLine("Customer ID: " + id);
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Units: " + units);
            Console.WriteLine("Total Bill: " + bill);
            if (bill <= 500)
            {
                Console.WriteLine("Category: Low");
            }
            else if (bill <= 1000)
            {
                Console.WriteLine("Category: Medium");
            }
            else
            {
                Console.WriteLine("Category: High");
            }
            totalRevenue = totalRevenue + bill;
        }
        Console.WriteLine("\nTotal Customers: " + customers);
        Console.WriteLine("Total Revenue: " + totalRevenue);
    }
}
