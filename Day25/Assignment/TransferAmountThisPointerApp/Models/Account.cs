using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TransferAmountThisPointerApp.Models
{
     class Account
    {
        private double balance;

        public Account(double balance)
        {
            this.balance = balance;
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public bool TrasnferAmount(Account receipient,double amount)
        {
            if (this.balance < amount)
            {
                return false;
            }

            this.balance -= amount;
            receipient.balance += amount;
            return true;
        }
    }
}
