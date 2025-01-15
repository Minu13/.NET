using NumberGuessWithOOPApp.Models;

namespace NumberGuessWithOOPApp
{
     class GameApp
    {
        static void Main(string[] args)
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
                    Console.Write("Enter your Name: ");
                    string playerName = Console.ReadLine();
                    Game game = new Game(playerName);
                    game.Start();
                }
                if (choice == "2")
                {
                    exit = true;
                    Console.WriteLine("Exiting the game. Goodbye!");
                }
                if (choice != "1" && choice != "2")
                {
                    Console.WriteLine("Invalid choice. Please select 1 or 2.");
                }
            }
        }
    }
}

