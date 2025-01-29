using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterfaceApp.Models
{
    class Car : Vehicle
    {
        public Car(string brandname, string chasisno) : base(brandname, chasisno)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"Car {Brandname} is moving...");
        }
    }
}
