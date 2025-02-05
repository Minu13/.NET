using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReadEmployeeListApp.Models
{
    public class Employee
    {
        public string  Name { get; set; }
        public string Designation { get; set; }

        public Employee(string name, string designtion )
        {
            Name = name;
            Designation = designtion;
        }
    }
}
