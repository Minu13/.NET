using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDelegateApp.Model
{
    public class User
    {
        private string name;

        public User(string name)
        {
            this.name = name;
        }

        public void ReceiveNotifiation(string message)
        {
            Program.PrintMessage(name, message);
        }
    }
}
