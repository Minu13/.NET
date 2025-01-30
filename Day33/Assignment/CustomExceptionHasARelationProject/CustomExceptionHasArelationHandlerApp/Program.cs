using AccountCommonLib.Models;

namespace CustomExceptionHasArelationHandlerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new Account(1001, "Minu", 1000);
            try
            {
                account.Withdraw(1000); 
            }
            catch (Exception ex) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }

            Console.WriteLine("End of main");
        }
    }
}
