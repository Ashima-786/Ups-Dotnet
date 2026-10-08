using System;
public class Login
{
    public static void Main(string[] args)
    {
        Console.Write("Enter username: ");
        string userName = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();
        if (userName == "Ashima")
        {
            if (password == "12345")
            {
                Console.WriteLine("Welcome Ashima! You have logged in successfully");
            } 
            else
            {
                Console.WriteLine("Incorrect password! Please try again.");    
            }
        }
        else
        {
            Console.WriteLine(" OOPS! Access Denied: Invalid username.");
        }
    }
}
