namespace OutPutArrayWithLongestNameApp
{
    class Program
    {
        static void Main()
        {
            string[] inputArray = { "Deepa", "MarkodaReddy", "MinuNair" };

            int maxLength = 0;
            int count = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length > maxLength)
                {
                    maxLength = inputArray[i].Length;
                }
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length == maxLength)
                {
                    count++;
                }
            }

            string[] outputArray = new string[count];
            int index = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length == maxLength)
                {
                    outputArray[index] = inputArray[i];
                    index++;
                }
            }

            Console.WriteLine("Output Array with Longest Names:");
            for (int i = 0; i < outputArray.Length; i++)
            {
                Console.WriteLine(outputArray[i]);
            }
        }
    }
}