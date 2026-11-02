using System;
using System.IO;
public class InvalidException : Exception
{
    public InvalidException(string message) : base(message)
    {
    }
}
public class InsufficientException : Exception
{
    public InsufficientException(string message) : base(message)
    {
    }
}
public class Bank_log
{
    private static double balance = 20000;
    private static string logFile = "ATM_Log.txt";
    public static void Main(string[] args)
    {
        Console.WriteLine("ATM BANKING SYSTEM => Log report ");
        Console.WriteLine("Current Date: " + DateTime.Now.ToString("dd-MM-yyyy"));
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Balance Check");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine() ?? "";
        string method = "";
        string status = "";
        try
        {
            switch (choice)
            {
                case "1":
                    method = "Deposit";
                    Deposit();
                    status = "Success";
                    break;
                case "2":
                    method = "Withdraw";
                    Withdraw();
                    status = "Success";
                    break;
                case "3":
                    method = "Balance Check";
                    CheckBalance();
                    status = "Success";
                    break;
                default:
                    method = "Invalid Choice";
                    throw new InvalidException("Please select a valid option.");
            }
        }
        catch (FormatException)
        {
            status = "Failed";
            Console.WriteLine("Error: Please enter a valid number.");
        }
        catch (InvalidException ex)
        {
            status = "Failed";
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (InsufficientException ex)
        {
            status = "Failed";
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            status = "Failed";
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
        finally
        {
            string date = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");

            Console.WriteLine("\nTRANSACTION DETAILS ");
            Console.WriteLine("Current Date: " + date);
            Console.WriteLine("Method: " + method);
            Console.WriteLine("Status: " + status);
            Console.WriteLine("Current Balance: " + balance);
            Console.WriteLine("Transaction Completed.");
            string log = "----------------------------------\n" +
                         "ATM BANKING SYSTEM LOG\n" +
                         "Current Date: " + date + "\n" +
                         "Method: " + method + "\n" +
                         "Status: " + status + "\n" +
                         "Current Balance: " + balance + "\n" +
                         "----------------------------------\n";
            try
            {
                File.AppendAllText(logFile, log);

                Console.WriteLine("Log saved successfully!");
                Console.WriteLine("Log Location: " + Path.GetFullPath(logFile));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Log File Error: " + ex.Message);
            }
        }
    }

    private static void Deposit()
    {
        Console.Write("Enter amount to deposit: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount <= 0)
        {
            throw new InvalidException("Deposit amount must be greater than zero.");
        }

        balance += amount;

        Console.WriteLine("Deposit Successful!");
    }

    private static void Withdraw()
    {
        Console.Write("Enter amount to withdraw: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount <= 0)
        {
            throw new InvalidException("Withdrawal amount must be greater than zero.");
        }

        if (amount > balance)
        {
            throw new InsufficientException("Insufficient balance.");
        }

        balance -= amount;

        Console.WriteLine("Withdrawal Successful!");
    }

    private static void CheckBalance()
    {
        Console.WriteLine("Available Balance: " + balance);
        Console.WriteLine("Balance checked successfully!");
    }
}
