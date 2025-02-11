
using MathOperatorLambda.Models;

namespace MathOperatorLambda
{
    public delegate string DMathOper(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            DMathOper operations = null;

            operations += (x, y) => $"Modulus: {x % y}";

            string result = operations(10, 2);
            Console.WriteLine(result);
        }

        private static void CaseStudy1()
        {
            MathOperations mathOps = new MathOperations();

            DMathOper operations = null;

            // Attaching methods to the delegate
            operations += mathOps.Add;
            operations += mathOps.Sub;
            operations += mathOps.Muli;

            // Invoking the multicast delegate and printing the results
            foreach (DMathOper operation in operations.GetInvocationList())
            {
                string result = operation(10, 2);
                Console.WriteLine(result);
            }
        }

    }
}

