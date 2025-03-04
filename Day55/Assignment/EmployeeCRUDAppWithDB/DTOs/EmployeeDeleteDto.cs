using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUDAppWithDB.DTOs
{
    public class EmployeeDeleteDto
    {
        public int Id { get; set; }
        public string HeaderTitle { get; set; } = "";
        public string Message { get; set; } = "";

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public double Salary { get; set; }
    }
}
