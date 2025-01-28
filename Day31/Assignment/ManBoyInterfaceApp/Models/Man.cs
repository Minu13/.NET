using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInterfaceApp.Models
{
    internal class Man : Imannerable
    {
        public void Depart()
        {
            Console.WriteLine("Man says: Bye!");
        }

        public void Wish()
        {
            Console.WriteLine("Man says: Hi!");
        }
    }
}
