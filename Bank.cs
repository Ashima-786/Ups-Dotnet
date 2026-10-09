using System;
public class Bank{
    public static void Main(string[] args)
    {
        Console.WriteLine("Api pin:");
        int pin = 1234;
        Console.Write("Account balance: ");
        double balance = 20000;
        Console.WriteLine("\nChoose an option:");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.Write("Enter choice (1 or 2): ");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            Console.Write("Enter amount to deposit: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            balance += depositAmount;
            Console.WriteLine("Deposit successful");
            Console.WriteLine("Present balance:"+ balance);
        }
        else if (choice=="2")
        {
            Console.Write("Enter amount to withdraw: ");
            int withdrawAmount = Convert.ToInt16(Console.ReadLine());
            if (withdrawAmount <= balance)
            {
                balance=balance-withdrawAmount;
                Console.WriteLine("Withdrawal successful");
                Console.WriteLine("Present balance:"+ balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
