using EmployeeManagementApp.Models;

namespace EmployeeManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee developer = new Developer(20000);
            Employee manager = new Manager(40000);

            PrintSalarySlip(developer);
            PrintSalarySlip(manager);

        }

        static void PrintSalarySlip(Employee employee)
        {
            Console.WriteLine($"Basic Salary: {employee.GetEmployeeType()} :{employee.BasicSalary}");
            Console.WriteLine($"Total CTC: {employee.CalculateCTC()}");
            Console.WriteLine (employee.GetDetails());
        }
    }
}
