using DesignFunctionApp.Models;

namespace DesignFunctionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            Console.WriteLine("Type: Account");
            Console.WriteLine($"Number of Methods:{account.GetMethodCount()}");
            Console.WriteLine($"Number of Properties: {account.GetPropertyCount()}");
            Console.WriteLine($"Number of Constructors: {account.GetConstructorCount()}");
        }
    }
}
