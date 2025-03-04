using EmployeeCRUDAppWithDB.Domain;
using Microsoft.Data.SqlClient;

namespace EmployeeCRUDAppWithDB.Services
{
    public class EmployeeDatabaseService : IEmployeeService
    {
        private readonly string _connectionString;

        public EmployeeDatabaseService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Add(Employee employee)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO EmpInfo (Name, Salary) VALUES (@Name, @Salary); SELECT SCOPE_IDENTITY();", conn))
                {
                    cmd.Parameters.AddWithValue("@Name", employee.Name);
                    cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Employee> Get()
        {
            var employees = new List<Employee>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Name, Salary FROM EmpInfo", conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            var id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            var name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                            var salary = reader.IsDBNull(2) ? 0.0 : (double)reader.GetDecimal(2);

                            employees.Add(new Employee
                            {
                                Id = id,
                                Name = name,
                                Salary = salary
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception("An error occurred while fetching employees", ex);
            }
            return employees;
        }


        public int HeadCount()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM EmpInfo", conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public Employee GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Id, Name, Salary FROM EmpInfo WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Employee
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Salary = (double)reader.GetDecimal(2)
                        };
                    }
                    return null;
                }
            }
        }

        public void Update(Employee employee)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE EmpInfo SET Name = @Name, Salary = @Salary WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", employee.Id);
                    cmd.Parameters.AddWithValue("@Name", employee.Name);
                    cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Remove(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM EmpInfo WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}

