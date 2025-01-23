using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConstructorInheritanceApp.Models
{
     class ChildV2:ParentV2
    {
        private string _name;
        public ChildV2() :base(10)
        {
            Console.WriteLine("ChildV2 created");
        }

        public ChildV2(int age, string name) : base(age)
        {
            _name = name;
            Console.WriteLine("childv2 created");
        }
        public string Name
        {
            get { return _name; }
        }
    }
}

