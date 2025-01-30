namespace RotateElementsby1PositionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 20, 30, 40 };
            int[] rotatedArray = RotateByOne(array);

            Console.WriteLine("Rotated Array:");
            foreach (int item in rotatedArray)
            {
                Console.Write(item + " ");
            }
        }

        static int[] RotateByOne(int[] array)
        {
            if (array.Length == 0)
                return array;

            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length - 1; i++)
            {
                result[i] = array[i + 1];
            }
            result[array.Length - 1] = array[0];

            return result;
        }
    }
}

