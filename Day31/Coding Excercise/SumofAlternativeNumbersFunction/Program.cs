namespace SumofAlternativeNumbersFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] inputArray = { 20, 30, 40, 50, 60 };
                int[] resultArray = SumAlternateNumbers(inputArray);

                Console.WriteLine("Output Array:");
                Console.WriteLine($"[{resultArray[0]}, {resultArray[1]}]");
            }

            static int[] SumAlternateNumbers(int[] array)
            {
                int sumEven = 0;
                int sumOdd = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumEven += array[i];
                    }
                    else
                    {
                        sumOdd += array[i];
                    }
                }

                return new int[] { sumEven, sumOdd };
            }
        }
    }
}


