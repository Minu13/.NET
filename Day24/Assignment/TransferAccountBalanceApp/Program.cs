using System.Security.Principal;
using TransferAccountBalanceApp.Models;

namespace TransferAccountBalanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account minuAccount = new Account(1, "Minu", 2000);
            Account sachinAccount = new Account(2, "Sachin", 3000);

            // Perform deposit and withdraw operations
            bool depositResult = minuAccount.Deposit(500);
            DisplayTransactionResult(minuAccount, "deposit", 500, depositResult);

            bool withdrawResult = sachinAccount.Withdraw(1000);
            DisplayTransactionResult(sachinAccount, "withdraw", 1000, withdrawResult);
        }

        static void DisplayTransactionResult(Account account, string transactionType, double amount, bool success)
        {
            if (!success)
            {
                Console.WriteLine($"Failed to {transactionType} {amount} to/from {account.Name}'s account.");
                return;
            }

            Console.WriteLine($"{transactionType}ed {amount} to/from {account.Name}'s account. New balance: {account.Balance}");
        }
    }
    }





