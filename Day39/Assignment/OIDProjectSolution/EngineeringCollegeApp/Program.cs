using EngineeringCollegeLib.Enum;
using EngineeringCollegeLib.Managers;
using EngineeringCollegeLib.Models;

namespace EngineeringCollegeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var studentManager = new StudentManager();
            var professorManager = new ProfessorManager();


            studentManager.AddStudent(new Student(1, "Minu", new DateTime(2000, 1, 15), Branch.ComputerScience));
            studentManager.AddStudent(new Student(2, "Maya", new DateTime(2001, 6, 23), Branch.Mechanical));


            professorManager.AddProfessor(new Professor(1, "Dr. Markonda", new DateTime(1975, 4, 10), 50000, 10));
            professorManager.AddProfessor(new Professor(2, "Dr. Mathi", new DateTime(1980, 9, 22), 60000, 8));

            Console.WriteLine("Students:");
            studentManager.DisplayAllStudents();

            Console.WriteLine("\nProfessors:");
            professorManager.DisplayAllProfessors();
        }
    }
}
