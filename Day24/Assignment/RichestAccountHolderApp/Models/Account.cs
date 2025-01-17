using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace RichestAccountHolderApp.Models
{
    class Account
    {
        private string _accountholderName;
        private double _balance;

        public Account(string accountholderName, double balance)
        {
            _accountholderName = accountholderName;
            _balance = balance;
        }

        public string AccountHolderName
        {
            get { return _accountholderName; }
        }

        public double Balance
        {
            get { return _balance; }
        }
    }
}