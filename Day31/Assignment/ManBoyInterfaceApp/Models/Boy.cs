using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInterfaceApp.Models
{
    internal class Boy : Iemotionable, Imannerable
    {
        public void cry()
        {
            Console.WriteLine("Boy is crying");
        }

        public void Depart()
        {
            Console.WriteLine("Boy says: Bye!");
        }

        public void laugh()
        {
            Console.WriteLine("Boy is laughing.");
        }

        public void Wish()
        {
            Console.WriteLine("Boy says: Hi!");
        }
    }
}
