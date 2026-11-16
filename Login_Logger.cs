
using System;
using System.IO;

public class Login_Logger
{
    public static void Main(string[] args)
    {
        string Correct_username = "admin";
        string Correct_password = "1234";
        int attempts = 0;

        try
        {
            while (attempts < 3)
            {
                Console.WriteLine("Enter Username:");
                string username = Console.ReadLine() ?? "";

                Console.WriteLine("Enter Password:");
                string password = Console.ReadLine() ?? "";

                if (username == Correct_username &&
                    password == Correct_password)
                {
                    Console.WriteLine("Valid User - Login successful");

                    File.AppendAllText(
                        "valid_users.txt",
                        "Username: " + username + "\n"
                    );

                    return;
                }
                else
                {
                    attempts++;

                    Console.WriteLine("Invalid User - Login failed. Try again");

                    File.AppendAllText(
                        "invalid_users.txt",
                        "Username: " + username + "\n"
                    );
                }
            }

            Console.WriteLine("Account locked. Try after sometime :)");
        }
        catch (IOException e)
        {
            Console.WriteLine("File error: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
