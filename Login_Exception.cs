using System;
public class InvalidLoginException : Exception
{ 
    public InvalidLoginException(string message) : base(message) {}
}
public class Login_Exception
{ 
    public static void Main(string[] args)
    { 
        string correctUsername = "Ashima";
        string correctPassword = "Ashi@2222"; 
        
        int maxAttempts = 3;
        int count = 0;
        
        while (count < maxAttempts)
        {
            try
            {
                Console.Write("Enter Username: ");
                string inputUsername = Console.ReadLine();
                Console.Write("Enter Password: ");
                string inputPassword = Console.ReadLine();
                count++;
                if (inputUsername == correctUsername && inputPassword == correctPassword)
                {
                    Console.WriteLine("Login Successful! Welcome to the system.");
                    break; 
                }
                else
                {
                    int attemptsLeft = maxAttempts - count;
                    
                    if (attemptsLeft > 0)
                    {
                        throw new InvalidLoginException("Invalid credentials. You have " + attemptsLeft + " attempts left.");
                    }
                    else
                    {
                        throw new InvalidLoginException("Invalid credentials. Account blocked for 15mins.");
                    }
                }
            }
            catch (InvalidLoginException ex)
            {
                Console.WriteLine("[Error] " + ex.Message);
            }
            finally{
                Console.WriteLine("Login Procedures Ended");
            }
        }
    }
}
