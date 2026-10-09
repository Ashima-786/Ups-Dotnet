using System;
public class VehicleRental
{
    public static void Main(string[] args)
    {
        int car = 1000;
        int bike = 300;
        Console.WriteLine("VEHICLE RENTAL MANAGEMENT SYSTEM");
        Console.WriteLine("1. Car - Rs.1000/day");
        Console.WriteLine("2. Bike - Rs.300/day");
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Do you have a driving licence? (yes/no): ");
        string licence = (Console.ReadLine() ?? "").ToLower();
        Console.Write("Enter rental duration in days: ");
        int days = Convert.ToInt32(Console.ReadLine());
        if (choice < 1 || choice > 2 ||
            age <= 20 || age > 45 ||
            (licence != "yes" && licence != "no") ||
            days <= 0)
        {
            Console.WriteLine("Invalid rental details");
            return;
        }
        if (licence == "no")
        {
            Console.WriteLine("Rental not allowed without a driving licence");
            return;
        }
        double rent = 0;
        string vehicle = "";
        if (choice == 1)
        {
            rent = car * days;
            vehicle = "Car";
        }
        else
        {
            rent = bike * days;
            vehicle = "Bike";
        }
        Console.WriteLine("--- RENTAL BILL ---");
        Console.WriteLine("Vehicle: " + vehicle);
        Console.WriteLine("Rental Duration: " + days + " days");
        Console.WriteLine("Rent per Day: Rs." + (choice == 1 ? car : bike));
        Console.WriteLine("Final Rental Amount: Rs." + rent);
    }
}
