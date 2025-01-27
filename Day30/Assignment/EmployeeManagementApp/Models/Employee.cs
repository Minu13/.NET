using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EmployeeManagementApp.Models
{
    abstract class Employee
    {
        protected double _basicSalary;

        public Employee(double BasicSalary)
        {
            _basicSalary = BasicSalary;

        }

        public double BasicSalary
        {
            get
            {
                return _basicSalary;
            }

        }
        public abstract double CalculateCTC();
        public abstract string GetEmployeeType();
        public abstract string GetDetails();

    }
}
