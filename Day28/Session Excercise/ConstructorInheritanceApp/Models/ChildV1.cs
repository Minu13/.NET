using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceApp.Models
{
    class ChildV1 : ParentV1
    {
        public ChildV1()
        {
            Console.WriteLine("Childv1 created");
        }
    }
}
