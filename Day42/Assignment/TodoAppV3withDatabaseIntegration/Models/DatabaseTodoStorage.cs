using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppV3withDatabaseIntegration.Models
{
    public class DatabaseTodoStorage : ITodoStorage
    {
        private readonly string _connectionString;
        public DatabaseTodoStorage(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Todo todo)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("INSERT INTO TodoItems (Description, Priority) VALUES (@Description, @Priority)", con);
                cmd.Parameters.AddWithValue("@Description", todo.Description);
                cmd.Parameters.AddWithValue("@Priority", todo.Priority);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public List<Todo> GetAll()
        {
            var todos = new List<Todo>();
            using (var con = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("SELECT Description, Priority FROM TodoItems", con);
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var todo = new Todo
                    {
                        Description = reader["Description"].ToString(),
                        Priority = reader["Priority"].ToString()
                    };
                    todos.Add(todo);
                }
                con.Close();
            }
            return todos;
        }
    }
}