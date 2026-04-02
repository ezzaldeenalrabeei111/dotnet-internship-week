using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

 
                Random random = new Random();
                int bestScore = int.MaxValue; // Stores the minimum attempts  
                string playAgain;

                Console.WriteLine("=== Welcome to the Guessing Game ===");

                do
                {
                    // Generate a random number between 1 and 100
                    int targetNumber = random.Next(1, 101);
                    int attempts = 0;
                    int userGuess = 0;

                    Console.WriteLine("\nI have picked a number between 1 and 100. Try to guess it!");

                    // Game loop: continues until the user guesses the correct number
                    while (userGuess != targetNumber)
                    {
                        Console.Write("Enter your guess: ");

                        // Input Validation using TryParse to prevent crashes
                        if (!int.TryParse(Console.ReadLine(), out userGuess))
                        {
                            Console.WriteLine("Invalid input! Please enter a numeric value.");
                            continue;
                        }

                        attempts++;

                        // Hints for the user
                        if (userGuess < targetNumber)
                            Console.WriteLine("Too Low! Try again.");
                        else if (userGuess > targetNumber)
                            Console.WriteLine("Too High! Try again.");
                        else
                        {
                            // Correct Guess
                            Console.WriteLine($"\nCongratulations! You guessed the number ({targetNumber}) in {attempts} attempts.");

                            // Scoring System based on attempts
                            if (attempts <= 3) Console.WriteLine("Rating: Excellent! 🌟");
                            else if (attempts <= 6) Console.WriteLine("Rating: Good! 👍");
                            else if (attempts <= 10) Console.WriteLine("Rating: Average 🙂");
                            else Console.WriteLine("Rating: Needs more practice! 😅");

                            // Tracking and updating the Best Score
                            if (attempts < bestScore)
                            {
                                bestScore = attempts;
                                Console.WriteLine($"🎉 New Personal Best: {bestScore} attempts!");
                            }
                            else
                            {
                                Console.WriteLine($"Your current best score is: {bestScore} attempts.");
                            }
                        }
                    }

                    // Ask the user to play again
                    Console.Write("\nDo you want to play again? (y/n): ");
                    playAgain = Console.ReadLine().ToLower();

                } while (playAgain == "y" || playAgain == "yes");

                Console.WriteLine("Thanks for playing! Goodbye.");
        }
    }   
}
 
