using EmployeeCRUDApp.Domain;
using System.Data;

namespace EmployeeCRUDApp.Services
{
    public class EmployeeInMemoryService : IEmployeeService
    {
        private readonly List<Employee> _employees;

        public EmployeeInMemoryService()
        {
            Console.WriteLine("Employee service created");

            _employees = new List<Employee>();

            _employees.Add(new Employee { Id = 1, Name = "Sachin", Salary = 1000 });
            _employees.Add(new Employee { Id = 2, Name = "Minu", Salary = 2000 });
            _employees.Add(new Employee { Id = 3, Name = "Jitendra", Salary = 3000 });
        }

        public IEnumerable<Employee> Get()
        {
            return _employees;
        }
        public int Headcount()
        {
            return _employees.Count();
        }

        public Employee GetbyId(int id)
        {
            return _employees.SingleOrDefault(e => e.Id == id);
        }

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Update(Employee employee)
        {
            var emp = GetbyId(employee.Id);
            if (emp != null)
            {
                emp.Salary = employee.Salary;
                emp.Name = employee.Name;
            }
        }

        public void Remove(int id)
        {
            var emp = GetbyId(id);
            if (emp != null)
            {
                _employees.Remove(emp);
            }
            else
            {
                throw new Exception("Employee was not found");
            }

        }
    }
}
