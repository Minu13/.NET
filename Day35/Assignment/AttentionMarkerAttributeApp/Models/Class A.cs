using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentionMarkerAttributeApp.Models
{
    public class Class_A
    {
        [ThisMethodNeedAttention]
        public void M1()
        {
            Console.WriteLine("Executing M1");
        }

        [ThisMethodNeedAttention]
        public void M2()
        {
            Console.WriteLine("Executing M2");
        }
        public void M3()
        {
            Console.WriteLine("Executing M3");
        }
        [ThisMethodNeedAttention]
        public void M4()
        {
            Console.WriteLine("Executing M4");
        }
        public void M5()
        {
            Console.WriteLine("Executing M4");
        }
    }
}
