using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Models
{
    class CustomerRepository : Icrudable
    {
        public void Create()
        {
            Console.WriteLine("Customer created");
        }

        public void Delete()
        {
            Console.WriteLine("Customer deleted");
        }

        public void Read()
        {
            Console.WriteLine("Customer selected from db");
        }

        public void Update()
        {
            Console.WriteLine("customer updated");
        }
    }
}
