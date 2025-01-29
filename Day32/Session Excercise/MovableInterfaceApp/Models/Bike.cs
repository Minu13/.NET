using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterfaceApp.Models
{
    class Bike : Vehicle
    {
        public Bike(string brandname, string chasisno) : base(brandname, chasisno)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"Bike {Brandname} is moving");
        }
    }
}
