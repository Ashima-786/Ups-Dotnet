using System;
public class Ecommerce
{
    public static void Main(string[] args)
    {
        int watch = 5000;
        int stationary = 3000;
        int dress = 8000;
        int shipping = 350;
        Console.WriteLine("E-COMMERCE ORDER AND PAYMENT SYSTEM");
        Console.WriteLine("1. Watch - Rs.5000");
        Console.WriteLine("2. Stationary - Rs.3000");
        Console.WriteLine("3. Dress - Rs.8000");
        Console.Write("Enter product choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter coupon code: ");
        string coupon = (Console.ReadLine() ?? "").ToLower();
        Console.Write("Enter payment method (GPay/PhonePe): ");
        string payment = (Console.ReadLine() ?? "").ToLower();
        if (choice < 1 || choice > 3 || quantity <= 0 ||
            (payment != "gpay" && payment != "phonepe"))
        {
            Console.WriteLine("Invalid order details");
            return;
        }
        int price = 0;
        string product = "";
        if (choice == 1)
        {
            price = watch;
            product = "Watch";
        }
        else if (choice == 2)
        {
            price = stationary;
            product = "Stationary";
        }
        else
        {
            price = dress;
            product = "Dress";
        }
        double orderValue = price * quantity;
        double discount = 0;
        if ((coupon == "wat001" && choice == 1) ||
            (coupon == "sat002" && choice == 2) ||
            (coupon == "dre003" && choice == 3))
        {
            discount = orderValue * 0.15;
        }
        double total = orderValue - discount + shipping;
        Console.WriteLine("--- ORDER BILL ---");
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Quantity: " + quantity);
        Console.WriteLine("Order Value: Rs." + orderValue);
        Console.WriteLine("Coupon Discount: Rs." + discount);
        Console.WriteLine("Shipping Charges: Rs." + shipping);
        Console.WriteLine("Payment Method: " + payment);
        Console.WriteLine("Final Amount: Rs." + total);
    }
}
