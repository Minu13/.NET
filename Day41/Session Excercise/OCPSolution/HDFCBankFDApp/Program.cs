using FDCoreLibrary.Model;
using HDFCBankFDApp.Policy;

namespace HDFCBankFDApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fd = new FixedDeposit(102, "Hdf customer1", 100000, 10, new Q2RatePolicy().CalculateRate);
            Console.WriteLine(fd.SimpleInterest);
        }
    }
}
