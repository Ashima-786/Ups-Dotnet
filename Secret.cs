
using System;

public class Secret
{
    public static void Main(string[] args)
    {
        Random r = new Random();
        string choice = "yes";
        while (choice == "yes")
        {
            int code = r.Next(1000, 10000);
            string secret = code.ToString();
            int score = 0;
            int correct = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Enter 4-digit code: ");
                string guess = Console.ReadLine();
                if (guess.Length != 4)
                {
                    Console.WriteLine("Enter 4 digits!");
                    i--;
                    continue;
                }
                correct = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (guess[j] == secret[j])
                    {
                        correct++;
                    }
                }
                Console.WriteLine("Correct positions: " + correct);
                Console.WriteLine("Attempts left: " + (10 - i));
                if (guess == secret)
                {
                    Console.WriteLine("Code cracked!");
                    score = (11 - i) * 10;
                    break;
                }
            }
            Console.WriteLine("Secret code: " + secret);
            Console.WriteLine("Score: " + score);
            Console.Write("Play again? (yes/no): ");
            choice = Console.ReadLine().ToLower();
        }
    }
}
