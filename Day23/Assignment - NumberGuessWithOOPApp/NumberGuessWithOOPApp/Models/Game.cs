

namespace NumberGuessWithOOPApp.Models
{
    class Game
    {
        private const int MaxAttempts = 3;
        private int _randomNumber;
        private int _attempts;
        private bool _guessedCorrectly;
        private string _playerName;


        public int Attempts
        {
            get
            {
                return _attempts;
            }
            set
            {
                _attempts = value;
            }
        }


        public bool GuessedCorrectly
        {
            get
            {
                return _guessedCorrectly;
            }
            set
            {
                _guessedCorrectly = value;
            }
        }

        public string PlayerName
        {
            get
            {
                return _playerName;
            }
            set
            {
                _playerName = value;
            }
        }

        public Game(string playerName)
        {
            PlayerName = playerName;
            Random random = new Random();
            _randomNumber = random.Next(1, 51);
            _attempts = 0;
            _guessedCorrectly = false;
        }

        public void Start()
        {
            Console.WriteLine($"{PlayerName}, can you guess the number in {MaxAttempts} attempts?");

            while (_attempts < MaxAttempts && !_guessedCorrectly)
            {
                Console.Write($"Attempt {_attempts + 1}: ");
                string input = Console.ReadLine();
                int playerGuess = int.Parse(input);

                _attempts++;

                if (playerGuess == _randomNumber)
                {
                    _guessedCorrectly = true;
                    Console.WriteLine("Congratulations! You are the winner.");
                }
                if (playerGuess < _randomNumber)
                {
                    Console.WriteLine("Your guess is less than the random number.");
                }
                if (playerGuess > _randomNumber)
                {
                    Console.WriteLine("Your guess is greater than the random number.");
                }
            }

            if (!_guessedCorrectly)
            {
                Console.WriteLine($"Sorry, you've used all your attempts. The random number was {_randomNumber}. The game is over.");
            }

            PromptPlayAgain();
        }

        private void PromptPlayAgain()
        {
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            string playAgainChoice = Console.ReadLine();

            if (playAgainChoice == "1")
            {
                Game newGame = new Game(PlayerName);
                newGame.Start();
                return;
            }

            Console.WriteLine("Thank you for playing! Goodbye!");
        }
    }
}
