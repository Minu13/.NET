namespace AlphabetInSequenceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAlphabetInSequence("abcd"));
            Console.WriteLine(IsAlphabetInSequence("abbc"));
            Console.WriteLine(IsAlphabetInSequence("xabc"));

            Console.Write("Enter a string to check:");
            string userInput = Console.ReadLine();
            bool result = IsAlphabetInSequence(userInput);
            Console.WriteLine($"Is the string in sequence: {result}");

        }
        static bool IsAlphabetInSequence(string input)
        {
            if (input.Length < 2)
            {
                return true;
            }

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] > input[i + 1])
                {
                    return false; 
                }
            }

            return true; 
        }
    }
}