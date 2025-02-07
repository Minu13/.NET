using EngineeringCollegeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCollegeLib.Managers
{
    public class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DisplayAllStudents()
        {
            foreach (var student in students)
            {
                student.DisplayDetails();
            }
        }
    }
}
