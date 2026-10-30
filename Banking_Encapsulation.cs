using System;
public class InvalidException : Exception 
{ 
    public InvalidException(string message) : base(message) 
    { 
        Console.WriteLine("..."); 
    } 
} 
public class InsufficientException : Exception 
{ 
    public InsufficientException(string message) : base(message) 
    { 
    } 
} 
public class Banking_Encapsulation {
    private static int Amount;
    public static void SetAmount(int amount)
    {
        if (amount > 0)
        {
            Amount = amount;
        }
        else
        {
            Console.WriteLine("Amount cannot be set");
        }
    }
    public static int GetAmount()
    {
        return Amount;
    }
    public static void Main(string[] args) 
    { 
        try 
        { 
            ProcessAtmTransaction(); 
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
    private static void ProcessAtmTransaction() 
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
            balance = Deposit(balance); 
            Console.WriteLine("Present balance: " + balance); 
        } 
        else if (choice == "2") 
        { 
            if (VerifyPin(pin))
            {
                balance = Withdraw(balance);
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

    private static bool VerifyPin(int correctPin)
    {
        Console.Write("Enter your ATM PIN: "); 
        int enteredPin = Convert.ToInt32(Console.ReadLine()); 
        return enteredPin == correctPin;
    }
    private static double Deposit(double balance) 
    { 
        Console.Write("Enter amount to deposit: "); 
        int inputAmount = Convert.ToInt32(Console.ReadLine()); 
        SetAmount(inputAmount);
        if (GetAmount() <= 0) 
        { 
            throw new InvalidException("Invalid deposit amount."); 
        } 
        balance += GetAmount(); 
        Console.WriteLine("Deposit successful"); 
        return balance; 
    } 
    private static double Withdraw(double balance) 
    { 
        Console.Write("Enter amount to withdraw: "); 
        int inputAmount = Convert.ToInt32(Console.ReadLine()); 
        SetAmount(inputAmount);
        if (GetAmount() <= 0) 
        { 
            throw new InvalidException("Withdrawal amount must be greater than zero."); 
        } 
        if (GetAmount() > balance) 
        { 
            throw new InsufficientException("Insufficient balance."); 
        } 
        balance -= GetAmount(); 
        Console.WriteLine("Withdrawal successful"); 
        return balance; 
    } 
}
