using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphism.Models
{
    class SavingsAccount : Account
    {
        public SavingsAccount(string id, string name, double balance) : base(id, name, balance)
        {
        }

        public override string type
        {
            get
            {
                return "SavingsAccount";
            }
        }

        public override void Withdraw(double amount)
        {
            if (_balance - amount < 1000) //fail early
            {
                var ex = new Exception("NO funds,min balance 1000");
                throw ex;
            }

            _balance = _balance - amount;
        }
    }
}
