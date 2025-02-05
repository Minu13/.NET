
using StreamReadEmployeeListApp.Models;

namespace StreamReadEmployeeListApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\temp\\emp_duplicate.csv";

            var uniqueEmployees = GetUniqueEmployees(filePath);
            var designationGroups = GroupEmployeesByDesignation(uniqueEmployees);

            DisplayGroupedEmployees(designationGroups);
        }

        static List<string> ReadCsvFile(string filePath)
        {
            var fs = new FileStream(filePath, FileMode.Open);
            var sr = new StreamReader(fs);
            List<string> records = new List<string>();

            while (true)
            {
                var line = sr.ReadLine();
                if (line == null) break;
                records.Add(line);
            }

            sr.Close();
            fs.Close();

            return records;
        }

        static List<Employee> GetUniqueEmployees(string filePath)
        {
            var records = ReadCsvFile(filePath);
            HashSet<string> uniqueNames = new HashSet<string>();
            List<Employee> employees = new List<Employee>();

            foreach (var record in records)
            {
                var fields = record.Split(',');
                var name = fields[1].Trim('\''); 
                var designation = fields[2].Trim('\''); 

                if (!uniqueNames.Contains(name))
                {
                    uniqueNames.Add(name);
                    employees.Add(new Employee(name, designation));
                }
            }

            return employees;
        }

        static Dictionary<string, List<Employee>> GroupEmployeesByDesignation(List<Employee> employees)
        {
            var map = new Dictionary<string, List<Employee>>();

            foreach (Employee employee in employees)
            {
                if (!map.ContainsKey(employee.Designation))
                {
                    map.Add(employee.Designation, new List<Employee>());
                }
                map[employee.Designation].Add(employee);
            }

            return map;
        }

        static void DisplayGroupedEmployees(Dictionary<string, List<Employee>> groupedEmployees)
        {
            int totalEmployees = 0;

            foreach (var group in groupedEmployees)
            {
                Console.WriteLine($"Designation: {group.Key}");
                foreach (var employee in group.Value)
                {
                    Console.WriteLine($"  Name: {employee.Name}");
                }
                Console.WriteLine($"Count: {group.Value.Count}");
                totalEmployees += group.Value.Count;
            }

            Console.WriteLine($"\nTotal Employee Count: {totalEmployees}");
        }
    }

    }

