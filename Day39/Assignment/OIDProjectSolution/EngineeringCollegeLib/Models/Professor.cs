using EngineeringCollegeLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCollegeLib.Models
{
    public class Professor : Person, ISalaried
    {
        public decimal BaseSalary { get; set; }
        public int Experience { get; set; } // In years

        public Professor(int id, string name, DateTime dateOfBirth, decimal baseSalary, int experience)
            : base(id, name, dateOfBirth)
        {
            BaseSalary = baseSalary;
            Experience = experience;
        }

        public decimal CalculateSalary()
        {
            return BaseSalary + (BaseSalary * 0.05m * Experience);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Professor ID: {Id}, Name: {Name}, DOB: {DateOfBirth.ToShortDateString()}, Salary: {CalculateSalary()}");
        }
    }

}
