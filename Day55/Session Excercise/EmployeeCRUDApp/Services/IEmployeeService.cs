using EmployeeCRUDApp.Domain;

namespace EmployeeCRUDApp.Services
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        Employee GetbyId(int id);
        int Headcount();
        void Remove(int id);
        void Update(Employee employee);
        public IEnumerable<Employee> Get();
    }
}