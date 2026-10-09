using System;
public class Hospital
{
    public static void Main(String[] args)
    {
        int generalward = 500;
        int privateward = 2000;
        int icu = 5000;
        int consultation = 800;
        Console.WriteLine("HOSPITAL PATIENT BILLING SYSTEM");
        Console.WriteLine("1. General Ward: " + generalward);
        Console.WriteLine("2. Private Ward: " + privateward);
        Console.WriteLine("3. ICU: " + icu);
        Console.WriteLine("Enter your choice:");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of days:");
        int days = Convert.ToInt32(Console.ReadLine());
        Console.Write("Senior citizen? (yes/no): ");
        string senior = (Console.ReadLine() ?? "").ToLower();
        Console.Write("Insurance eligible? (yes/no): ");
        string insurance = (Console.ReadLine() ?? "").ToLower();
        if (choice < 1 || choice > 3 || days <= 0 ||
        (senior != "yes" && senior != "no") ||
        (insurance != "yes" && insurance != "no")){
        Console.WriteLine("Invalid patient details");
        return;
    }
    double roomCharge = 0;
    if (choice == 1)
        roomCharge = generalward * days;
    else if (choice == 2)
        roomCharge = privateward * days;
    else
        roomCharge = icu * days;
    double discount = 0;
    if (senior == "yes")
        discount = roomCharge * 0.05;
    double total = roomCharge + consultation - discount;
    Console.WriteLine("--- PATIENT BILL ---");
    Console.WriteLine("Room Charges: Rs." + roomCharge);
    Console.WriteLine("Consultation Charges: Rs." + consultation);
    Console.WriteLine("Senior Citizen Discount: Rs." + discount);
    Console.WriteLine("Insurance Eligible: " + insurance);
    Console.WriteLine("Final Amount Payable: Rs." + total);
    }
}

