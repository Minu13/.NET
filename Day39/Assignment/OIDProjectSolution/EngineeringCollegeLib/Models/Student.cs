using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngineeringCollegeLib.Enum;

namespace EngineeringCollegeLib.Models
{

    public class Student : Person
    {
        public Branch Branch { get; set; }

        public Student(int id, string name, DateTime dateOfBirth, Branch branch)
            : base(id, name, dateOfBirth)
        {
            Branch = branch;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Student ID: {Id}, Name: {Name}, DOB: {DateOfBirth.ToShortDateString()}, Branch: {Branch}");
        }
    }
}