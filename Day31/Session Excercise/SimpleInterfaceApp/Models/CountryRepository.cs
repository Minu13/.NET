using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Models
{
    internal class CountryRepository : Icrudable
    {
        public void Create()
        {
            Console.WriteLine("Country created");
        }

        public void Delete()
        {
            Console.WriteLine("Country deleted");
        }

        public void Read()
        {
            Console.WriteLine("Country selected");
        }

        public void Update()
        {
            Console.WriteLine("Country updated");
        }
    }
}
