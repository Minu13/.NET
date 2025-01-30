using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCommonLib.Models
{
    public class InsufficientFundsException : Exception
    {
        private Account _account;

        public InsufficientFundsException(Account account)
        {
            _account = account;
        }
                public override string Message
        {
            get
            {
                return $"Account holder: {_account.Name}, does not have sufficient funds for withdrawal. Balance is only: {_account.Balance}.";
            }
        }


    }
}
