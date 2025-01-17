using RichestAccountHolderApp.Models;

namespace RichestAccountHolderApp
{
    class AccountManager
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[]
            {
                new Account("Minu", 2000),
                new Account("Sachin", 3000),
                new Account("MarkondaReddy", 5000),
                new Account("DeepaSundarm", 10000),
                new Account("Kannan", 8000)
            };

            PrintRichestAccountHolder(accounts);
        }

        public static void PrintRichestAccountHolder(Account[] accounts)
        {
            if (accounts.Length == 0)
            {
                Console.WriteLine("No accounts found.");
                return;
            }

            Account richestAccount = null;
            foreach (Account account in accounts)
            {
                if (richestAccount == null || account.Balance > richestAccount.Balance)
                {
                    richestAccount = account;
                }
            }
            if (richestAccount != null)
            {
                Console.WriteLine($"The richest account holder is: {richestAccount.AccountHolderName}");
            }

        }
    }
}

