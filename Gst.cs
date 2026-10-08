using System;
public class Gst
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the product name : ");
        String product = Console.ReadLine();
        Console.Write("Enter the product price : ");
        double price = Convert.ToDouble(Console.ReadLine());
        if (price > 5000)
        {
            double total=(price-(price*0.05))+(price*0.18);
            
            Console.WriteLine("The New Discounted Price(Including GST) is : "+total);
        }
        else
        {
            Console.WriteLine("No amount  discounted with GST : "+(double)(price+price*0.18));
        }
    }
}
