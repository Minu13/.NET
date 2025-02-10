using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountFactoryCommLib.Services
{
    public class SavingsAccount : IAccount
    {
        public void AccountType()
        {
            Console.WriteLine("This is Savings Account");
        }
    }
}
