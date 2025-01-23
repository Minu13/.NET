namespace NextAlphabetCharacterApp
{

    public class NextAlphabetBeginner
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();
            string outputString = GetNextAlphabetString(inputString);
            Console.WriteLine($"Input: {inputString}");
            Console.WriteLine($"Output: {outputString}");
        }

        public static string GetNextAlphabetString(string input)
        {
            string output = "";

            foreach (char c in input)
            {
                if (c == 'z')
                {
                    output += 'a';
                }
                else if (c == 'Z')
                {
                    output += 'A';
                }
                else if (char.IsLetter(c))
                {
                    output += (char)(c + 1);
                }
                else
                {
                    output += c;
                }
            }

            return output;
        }
    }

}