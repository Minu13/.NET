using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountFactoryCommLib.Services
{
    public class CurrentAccount : IAccount
    {
        public void AccountType()
        {
            Console.WriteLine("This is Current Account");
        }
    }
}
