using System;
public class Login1
{
    public static void Main(string[] args)
    {
        Console.Write("Enter username: ");
        string userName = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();
        if (userName == "Ashima" && password == "12345")
        {
            Console.WriteLine("Welcome Ashima! You have logged in successfully");
        }
        else
        {
            Console.WriteLine("OOP! Access Denied: Enter the correct user details.");
        }
    }
}
