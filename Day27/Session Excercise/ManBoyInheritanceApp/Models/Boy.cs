using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Models
{
     class Boy : Man
    {
        public override void play()
        {
            Console.WriteLine("Boy plays..");
        }
        public void eat()
        {
            Console.WriteLine("Boy eats..");
        }
    }
}
