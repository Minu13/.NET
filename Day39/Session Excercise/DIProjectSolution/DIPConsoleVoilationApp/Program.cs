using DIPConsoleVoilationApp.HighLevel;

namespace DIPConsoleVoilationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new TaxCalculator(LogType.TEXT);

            Console.WriteLine(calc.CalculateTax(10000, 20));
            Console.WriteLine(calc.CalculateTax(10000, 0));
        }
    }
}
