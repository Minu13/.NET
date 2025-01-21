using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Models
{
     class Man
    {
        public virtual void play()
        {
            Console.WriteLine("Man Playing");
        }

        public void read()
        {
            Console.WriteLine("Man reading");
        }
    }
}
