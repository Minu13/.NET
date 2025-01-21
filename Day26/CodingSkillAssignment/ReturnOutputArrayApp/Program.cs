namespace ReturnOutputArrayApp
{
    public class Program
    {
        public static string[] AddBorder(string[] inputArray)
        {
            string border = "****";
            string[] resultArray = new string[inputArray.Length + 2];

            resultArray[0] = border;


            for (int index = 0; index < inputArray.Length; index++)
            {
                resultArray[index + 1] = "*" + inputArray[index] + "*";
            }

            resultArray[resultArray.Length - 1] = border;

            return resultArray;
        }

        public static void Main(string[] args)
        {
            string[] inputArray = { "abc", "efg", "ijk" };
            string[] outputArray = AddBorder(inputArray);

            foreach (string str in outputArray)
            {
                Console.WriteLine(str);
            }
        }
    }

}
