using LogestAccountHolderNameApp.Models;

namespace LongestAccountHolderNameApp
{
    class AccountManager
    {
        private const int MinNameLength = 8;
        static void Main(string[] args)
        {
            Account[] accounts = new Account[]
            {
                new Account ("Minu",2000),
                new Account("Sachin",3000),
                new Account("MarkondaReddy",5000),
                new Account("DeepaSundarm",10000),
                new Account("Kannan",8000)
            };

            PrintLongestAccountHolderName(accounts);
        }

        public static void PrintLongestAccountHolderName(Account[] accounts)
        {
            Console.WriteLine("Account holders with long names:");
            foreach (Account account in accounts)
            {
                if (account.AccountHolderName.Length >= MinNameLength)
                {
                    Console.WriteLine(account.AccountHolderName);
                }
            }
        }
    }
}





