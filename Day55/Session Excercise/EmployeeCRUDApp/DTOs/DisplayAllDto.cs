using EmployeeCRUDApp.Domain;

namespace EmployeeCRUDApp.DTOs
{
    public class DisplayAllDto
    {
        public int count { get; set; }
        public string HeaderTitle { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
