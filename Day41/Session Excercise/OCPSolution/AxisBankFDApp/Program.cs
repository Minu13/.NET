using AxisBankFDApp.Policy;
using FDCoreLibrary.Model;

namespace AxisBankFDApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fd1 = new FixedDeposit(101, "abc", 10000, 10, () => {

                return .9;
            });
            Console.WriteLine(fd1.SimpleInterest);

        }
    }
}
