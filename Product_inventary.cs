
using System;
using System.IO;
public class Product_inventary
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            name = name.ToLower();
            File.AppendAllText("products.txt",
                name + " " + price + " " + quantity + "\n");
            Console.WriteLine("\nProduct Details:");

            string[] data = File.ReadAllLines("products.txt");
            foreach (string p in data)
            {
                Console.WriteLine(p);
            }

            Console.Write("\nSearch Product: ");
            string search = Console.ReadLine();

            search = search.ToLower();

            bool found = false;

            foreach (string p in data)
            {
                string[] d = p.Split(' ');

                if (d[0] == search)
                {
                    double total = Convert.ToDouble(d[1]) *
                                   Convert.ToInt32(d[2]);

                    Console.WriteLine("\nProduct Found!");
                    Console.WriteLine("Name: " + d[0]);
                    Console.WriteLine("Price: " + d[1]);
                    Console.WriteLine("Quantity: " + d[2]);
                    Console.WriteLine("Total Value: " + total);

                    found = true;
                }
            }

            if (found == false)
            {
                Console.WriteLine("Product Not Found!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Input!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File Not Found!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
