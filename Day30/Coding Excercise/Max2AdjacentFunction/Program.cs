namespace Max2AdjacentFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 7, 8, 10, 6 };

            int maxProduct = FindMaxAdjacentProduct(array);

            Console.WriteLine("The maximum product of two adjacent elements is: " + maxProduct);
        }

        static int FindMaxAdjacentProduct(int[] array)
        {
            int maxProduct = int.MinValue;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int product = array[i] * array[i + 1];

                if (product > maxProduct)
                {
                    maxProduct = product;
                }
            }
            return maxProduct;
        }
    }
}

