using FlattenArraywithAndWithoutLinqApp.Models;

namespace FlattenArraywithAndWithoutLinqApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<List<List<string>>> nestedArray = new List<List<List<string>>>
        {
            new List<List<string>> { new List<string> { "a", "c" } },
            new List<List<string>> { new List<string> { "b", "d" } }
        };

            List<string> flattenedLinq = ArrayFlattener.FlattenLinq(nestedArray);
            Console.WriteLine("Flattened (LINQ): " + string.Join(",", flattenedLinq));

            List<string> flattenedIterative = ArrayFlattener.FlattenIterative(nestedArray);
            Console.WriteLine("Flattened (Iterative): " + string.Join(",", flattenedIterative));
        }
    }

}
