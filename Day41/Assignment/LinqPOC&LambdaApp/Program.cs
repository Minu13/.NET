namespace LinqPOC_LambdaApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] names = { "Sachin", "Deepa", "Sunil", "Mathi", "Shiva", "Markonda", "Shalini", "Prem" };

            // Call methods and display results
            DisplayEvenNumbers(numbers);
            DisplayNamesStartingWithS(names);
            DisplayNamesStartingWithSOrdered(names);
            
        }

        static void DisplayEvenNumbers(int[] numbers)
        {
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            Console.WriteLine("Even numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
        }


        static void DisplayNamesStartingWithS(string[] names)
        {
            var namesStartingWithS = names.Where(name => name.StartsWith("S")).ToList(); // Directly to List

            Console.WriteLine("Names starting with 'S':");
            foreach (var name in namesStartingWithS)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }

        static void DisplayNamesStartingWithSOrdered(string[] names)
        {
            var namesStartingWithSOrdered = names.Where(name => name.StartsWith("S"))
                                                .OrderBy(name => name)
                                                .ToList(); 

            Console.WriteLine("Names starting with 'S' (Ordered):");
            foreach (var name in namesStartingWithSOrdered)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
    }
}