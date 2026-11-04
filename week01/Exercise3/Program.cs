using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string playAgain = "yes";
        while (playAgain == "yes")
        {
            // Generate a random number from 1 to 100 for this round
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0; // Stretch Challenge 1: Track number of guesses per game

            Console.WriteLine("--- New Game Started! ---");

            // Inner loop: Keep guessing until the magic number is found
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Display total guesses for this round
            Console.WriteLine($"It took you {guessCount} guesses to find the magic number.");
            Console.WriteLine();

            // Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().Trim().ToLower();
            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
    
}