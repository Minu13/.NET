using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Models
{
    class Manager : Employee
    {
        private double _HRA;
        private double _TA;

        public Manager(double BasicSalary) : base(BasicSalary)
        {
            _HRA = 0.5 * BasicSalary;
            _TA = 0.6 * BasicSalary;
        }

        public override double CalculateCTC()
        {
            return BasicSalary + _HRA + _TA;
        }

        public override string GetEmployeeType()
        {
            return "Manager";
        }

        public override string GetDetails()
        {
            return $"HRA: {HRA}\nTA: {TA}";
        }

        public double HRA
        {
            get
            {
                return _HRA;
            }
        }
        public double TA
        {
            get
            {
                return _TA;
            }
        }
    }
}