using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethodApp.Models
{
    class SavingsAccount : Account
    {
        public SavingsAccount(double balance) : base(balance) { }
    
    public override void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance in account");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Withdraw {amount} from Savings account. New Balance {Balance}");

        }
    }
}
