namespace ReverseArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string[] array = { "mmm", "rrr", "sss", "ttt", "ddd" };

                Console.WriteLine("Original array:");
                PrintArray(array);

                ReverseArray(array);

                Console.WriteLine("Reversed array:");
                PrintArray(array);
            }

            static void ReverseArray(string[] array)
            {
                int left = 0;
                int right = array.Length - 1;

                while (left < right)
                {
                    string temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;

                    left++;
                    right--;
                }
            }

            static void PrintArray(string[] array)
            {
                foreach (string element in array)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
