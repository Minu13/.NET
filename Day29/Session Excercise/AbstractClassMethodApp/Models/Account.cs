using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethodApp.Models
{
    abstract class Account
    {
        private double _balance;

        public Account(double balance)
        {
            _balance = balance;
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public void Deposit(double amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposited {amount} to account. New balance {Balance}");
        }

        public abstract void Withdraw(double amount);

    }
}
