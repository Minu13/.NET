using TransferAmountThisPointerApp.Models;

namespace TransferAmountThisPointerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(20000);
            Account acc2 = new Account(5000);

            Console.WriteLine("Initial Account Details:");
            DisplayAccountDetails(acc1, "acc1");
            DisplayAccountDetails(acc2, "acc2");

            bool transferSuccessful = acc1.TrasnferAmount(acc2, 5000);
            DisplayTransferResult(transferSuccessful);

            Console.WriteLine("Account Details After Transfer:"); 
            DisplayAccountDetails(acc1, "acc1"); 
            DisplayAccountDetails(acc2, "acc2");


            static void DisplayAccountDetails(Account account, string accountIdentifier)
            {
                Console.WriteLine($"Account: {accountIdentifier}");
                Console.WriteLine($"Balance: {account.GetBalance()}");
            }


            static void DisplayTransferResult(bool transferSucessful)
            {
                if (transferSucessful)
                {
                    Console.WriteLine("Transfer Successful");
                    return;
                }
                Console.WriteLine("Insufficient Balance");
            }
        }
    }
}
