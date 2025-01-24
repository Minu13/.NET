using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethodApp.Models
{
    class CurrentAccount : Account
    {
        public CurrentAccount(double Balance) : base(Balance) { }

        public override void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance in account");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Withdraw {amount} from current account. New Balance {Balance}");
        }
    }
}
