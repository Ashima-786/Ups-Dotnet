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
            bool won = false;
            Console.WriteLine("Guess the 4-digit secret code!");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Enter your 4-digit guess: ");
                string guess = Console.ReadLine();
                if (guess.Length != 4)
                {
                    Console.WriteLine("Enter exactly 4 digits!");
                    i--;
                    continue;
                }
                int correct = 0;
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
                    Console.WriteLine("Congratulations! Code cracked!");
                    score = (11 - i) * 10;
                    won = true;
                    break;
                }
            }
            if (won == false)
            {
                Console.WriteLine("Game over! Code was " + secret);
            }
            Console.WriteLine("Score: " + score);
            Console.Write("Try a new code (yes/no): ");
            choice = Console.ReadLine().ToLower();
        }
    }
}
