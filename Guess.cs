using System;
public class Guess
{
    public static void Main(string[] args)
    {
        Random r = new Random();
        string choice = "yes";
        while (choice == "yes")
        {
            int number = r.Next(1, 101);
            int guess;
            int attempts = 0;
            int score = 0;
            Console.WriteLine("Guess a number between 1 and 100");
            while (attempts < 5)
            {
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;
                if (guess == number)
                {
                    Console.WriteLine("Correct! You won!");
                    score = (6 - attempts) * 20;
                    break;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine("Too low!");
                }

                Console.WriteLine("Attempts left: " + (5 - attempts));
            }
            if (attempts == 5 && score == 0)
            {
                Console.WriteLine("Game over! Number was " + number);
            }
            Console.WriteLine("Score: " + score);
            Console.Write("Play again (yes/no): ");
            choice = Console.ReadLine().ToLower();
        }
    }
}
