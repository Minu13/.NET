namespace BoxingUnboxingApp
{
    class Program
    {
        static void Main()
        {
            object[] objectArray = new object[] { 10, 20, 30, 40, 50 };

            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;


            for (int i = 0; i < objectArray.Length; i++)
            {
                int num = (int)objectArray[i]; // Unboxing
                sum += num;

                if (num > max)
                {
                    max = num;
                }

                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
        }
    }
}