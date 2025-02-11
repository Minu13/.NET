using MathOperatorDelegate.Models;

namespace MathOperatorDelegate
{
    public delegate string DMathOper(int x, int y);
    public class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();

            DMathOper operations = null;

            
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

