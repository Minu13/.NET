using AccountFactoryCommLib.Services;

namespace AccountFactoryAppLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           AccountFactory factory = new AccountFactory();

            IAccount savingsaccount = factory.CreateAccount(AccountType.Savings);
            savingsaccount.AccountType();

            IAccount currentaccount = factory.CreateAccount(AccountType.Current);
            currentaccount.AccountType();
                    
        }
    }
}
