using AbstractClassMethodApp.Models;

namespace AbstractClassMethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account savings = new SavingsAccount(1000);
            Account current = new CurrentAccount(1000);

            savings.Deposit(500);
            savings.Withdraw(200);

            current.Deposit(1000);
            savings.Withdraw(2500);
        }

    }
}
