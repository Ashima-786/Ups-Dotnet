
using System;

public class Bank
{
    public static void Main(string[] args)
    {
        Console.WriteLine("ATM PIN:1234");
        int pin=1234;
        double balance = 20000;
        Console.WriteLine("Account balance: " + balance);

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
            Console.WriteLine("Present balance: " + balance);
        }
        else if (choice == "2")
        {
            Console.Write("Enter your ATM PIN: ");
            int enteredPin = Convert.ToInt32(Console.ReadLine());

            if (enteredPin == pin)
            {
                Console.Write("Enter amount to withdraw: ");
                int withdrawAmount = Convert.ToInt32(Console.ReadLine());

                if (withdrawAmount > 0 && withdrawAmount <= balance)
                {
                    balance = balance - withdrawAmount;

                    Console.WriteLine("Withdrawal successful");
                    Console.WriteLine("Present balance: " + balance);
                }
                else
                {
                    Console.WriteLine("Invalid amount or insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
