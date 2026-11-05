using System;

abstract class Payment 
{ 
    public string TransactionId; 
    public string CustomerName; 
    public abstract void ProcessPayment(double amount); 
}

class UPIPayment : Payment 
{ 
    public override void ProcessPayment(double amount) 
    { 
        if (amount <= 0) 
        { 
            Console.WriteLine("Invalid Payment Amount"); 
            return; 
        } 
        double charge = amount * 0 / 100; 
        double finalAmount = amount + charge; 
        
        Console.WriteLine("Payment Method: UPI"); 
        Console.WriteLine("Customer: " + CustomerName); 
        Console.WriteLine("Transaction Amount: " + amount); 
        Console.WriteLine("Transaction Charge: " + charge); 
        Console.WriteLine("Final Amount: " + finalAmount); 
        Console.WriteLine("Payment Successful"); 
    } 
} 

class CreditCardPayment : Payment 
{ 
    public override void ProcessPayment(double amount) 
    { 
        if (amount <= 0) 
        { 
            Console.WriteLine("Invalid Payment Amount"); 
            return; 
        } 
        double charge = amount * 2 / 100; 
        double finalAmount = amount + charge; 
        
        Console.WriteLine("Payment Method: Credit Card"); 
        Console.WriteLine("Customer: " + CustomerName); 
        Console.WriteLine("Transaction Amount: " + amount); 
        Console.WriteLine("Transaction Charge: " + charge); 
        Console.WriteLine("Final Amount: " + finalAmount); 
        Console.WriteLine("Payment Successful"); 
    } 
}

class DebitCardPayment : Payment 
{ 
    public override void ProcessPayment(double amount) 
    { 
        if (amount <= 0) 
        { 
            Console.WriteLine("Invalid Payment Amount"); 
            return; 
        } 
        double charge = amount * 1 / 100;
        double finalAmount = amount + charge; 
        
        Console.WriteLine("Payment Method: Debit Card"); 
        Console.WriteLine("Customer: " + CustomerName); 
        Console.WriteLine("Transaction Amount: " + amount); 
        Console.WriteLine("Transaction Charge: " + charge); 
        Console.WriteLine("Final Amount: " + finalAmount); 
        Console.WriteLine("Payment Successful"); 
    } 
} 

public class Atm_abstract
{ 
    public static void Main(string[] args) 
    { 
        Console.WriteLine("Select Payment Type (1: UPI, 2: Credit Card, 3: Debit Card): ");
        string choice = Console.ReadLine();

        Payment payment = null;

        if (choice == "1")
        {
            payment = new UPIPayment();
        }
        else if (choice == "2")
        {
            payment = new CreditCardPayment();
        }
        else if (choice == "3")
        {
            payment = new DebitCardPayment();
        }
        else
        {
            Console.WriteLine("Invalid payment type selected.");
            return;
        }
        Console.Write("Enter Customer Name: ");
        payment.CustomerName = Console.ReadLine();
        Console.Write("Enter Transaction ID: ");
        payment.TransactionId = Console.ReadLine();
        Console.Write("Enter Amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(); 
        payment.ProcessPayment(amount);
    } 
}
