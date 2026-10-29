using System;
public class InvalidException : Exception
{
    public  InvalidException(string message) : base(message) {
        Console.WriteLine("...");
    }
}

public class InsufficientException : Exception
{
    public InsufficientException(string message) : base(message) { }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("ATM PIN:1234");
            int pin = 1234;
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

                if (depositAmount <= 0)
                {
                    throw new InvalidException("Invalid deposit amount.");
                }

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
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());

                    if (withdrawAmount <= 0)
                    {
                        throw new InvalidException("Withdrawal amount must be greater than zero.");
                    }
                    if (withdrawAmount > balance)
                    {
                        throw new InsufficientException("Insufficient balance.");
                    }

                    balance -= withdrawAmount;
                    Console.WriteLine("Withdrawal successful");
                    Console.WriteLine("Present balance: " + balance);
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
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
        catch (InvalidException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (InsufficientException ex)
        {
            Console.WriteLine("Error: Sorry you do not have sufficient balance. " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction process completed.");
        }
    }
}
