using System;
public class Hotel_room
{
    public static void Main(string[] args)
    {
        int room_no = 201;
        int standard = 1000;
        int deluxe = 2000;
        int suite = 3000;
        Console.WriteLine("Room Number: " + room_no);
        Console.WriteLine("1. Standard");
        Console.WriteLine("2. Deluxe");
        Console.WriteLine("3. Suite");
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.Write("No of days stay: ");
        int days = Convert.ToInt32(Console.ReadLine());
        Console.Write("Customer type (Membership/Normal): ");
        string customer = Console.ReadLine()??"";
        Console.Write("Include food? (yes/no): ");
        string food = Console.ReadLine().ToLower();
        if (choice < 1 || choice > 3 || days <= 0 ||
            (customer != "membership" && customer != "normal") ||
            (food != "yes" && food != "no"))
        {
            Console.WriteLine("Invalid booking details");
            return;
        }
        double room_charge = 0;
        if (choice == 1)
            room_charge = standard * days;
        else if (choice == 2)
            room_charge = deluxe * days;
        else
            room_charge = suite * days;
        double discount = 0;
        if (customer == "membership")
            discount = room_charge * 0.05;
        double food_charge = 0;
        if (food == "yes")
            food_charge = 500 * days;
        double subtotal = room_charge - discount + food_charge;
        double gst = subtotal * 0.12;
        double total = subtotal + gst;
        Console.WriteLine("--- HOTEL BILL ---");
        Console.WriteLine("Room Number: " + room_no);
        Console.WriteLine("Room Charge: " + room_charge);
        Console.WriteLine("Membership Discount: " + discount);
        Console.WriteLine("Food Charge: " + food_charge);
        Console.WriteLine("Subtotal: " + subtotal);
        Console.WriteLine("GST (12%): " + gst);
        Console.WriteLine("Final Bill: " + total);
    }
}
