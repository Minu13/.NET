using TaxCommonLib.HighLevel;

namespace DIPConsoleVoilationApp.LowLevel
{
    internal class TextLogger : IErrorLogger
    {
        public void Log(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(ex.StackTrace);
            Console.WriteLine("File is created for the logs..");

            Console.ResetColor();
        }
    }
}
