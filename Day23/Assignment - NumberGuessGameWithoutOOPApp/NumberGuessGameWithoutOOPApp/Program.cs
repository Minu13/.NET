using System;

namespace NumberGuessGameWithoutOOPApp
{
   class Program
    {
        const int MaxAttempts = 3;
        public static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Welcome to the game!");
                Console.WriteLine("1. Start the game");
                Console.WriteLine("2. Exit the game");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    StartGame();
                }

                if (choice == "2")
                {
                    exit = true;
                }

                if (choice != "1" && choice != "2")
                {
                    Console.WriteLine("Invalid choice. Please choose 1 or 2.");
                }
            }
        }

        static void StartGame()
        {
            Console.Write("Enter your Name: ");
            string playerName = Console.ReadLine();

            Random random = new Random();
            int randomNumber = random.Next(1, 51);

            Console.WriteLine($"{playerName}, Can you guess the number in three attempts?");

            int attempts = 0;
            bool guessedCorrectly = false;

            while (attempts < MaxAttempts && !guessedCorrectly)
            {
                Console.Write($"Attempt {attempts + 1}: ");
                int playerGuess = int.Parse(Console.ReadLine());
                attempts++;

                if (playerGuess < randomNumber)
                {
                    Console.WriteLine("Your guess is less than the random number.");
                }

                if (playerGuess > randomNumber)
                {
                    Console.WriteLine("Your guess is greater than the random number.");
                }

                if (playerGuess == randomNumber)
                {
                    Console.WriteLine("Congratulations! You are the winner.");
                    guessedCorrectly = true;
                }
            }

            if (!guessedCorrectly)
            {
                Console.WriteLine($"Sorry, you've used all your attempts. The random number was {randomNumber}. The game is over.");
            }

            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            string playAgainChoice = Console.ReadLine();
            

            if (playAgainChoice == "1")
            {
                StartGame();
            }
        }
    }

}
