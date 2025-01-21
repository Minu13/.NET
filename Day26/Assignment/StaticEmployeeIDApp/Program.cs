using StaticEmployeeIDApp.Models;

namespace StaticEmployeeIDApp
{
     class Program
    {
        static void Main(string[] args)
        {
            var e1 = new Employee("Deepa");
            var e2 = new Employee("Minu");
            var e3 = new Employee("Markonda");

            Console.WriteLine("Employee1 ID:" + e1.EmployeeID);
            Console.WriteLine("Employee2 ID:" + e2.EmployeeID);
            Console.WriteLine("Employee3 ID:" + e3.EmployeeID);
        }
    }
}
