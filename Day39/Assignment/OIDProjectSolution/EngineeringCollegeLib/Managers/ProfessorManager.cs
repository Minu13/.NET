using EngineeringCollegeLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCollegeLib.Managers
{
    public class ProfessorManager
    {
        private List<Professor> professors = new List<Professor>();

        public void AddProfessor(Professor professor)
        {
            professors.Add(professor);
        }

        public void DisplayAllProfessors()
        {
            foreach (var professor in professors)
            {
                professor.DisplayDetails();
            }
        }
    }
}
