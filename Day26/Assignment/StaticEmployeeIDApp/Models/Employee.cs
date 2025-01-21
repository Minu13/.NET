
namespace StaticEmployeeIDApp.Models
{
    class Employee
    {
        private static int lastID = 0;
        private int _employeeID;
        private string _name;

        public Employee(string name)
        {
            _employeeID = ++lastID;
            _name = name;
        }

        public int EmployeeID
        {
            get
            {
                return _employeeID;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}