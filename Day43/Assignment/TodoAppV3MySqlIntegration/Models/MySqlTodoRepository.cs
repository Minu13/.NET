using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppV3MySqlIntegration.Models
{
    public class MySqlTodoRepository : ITodoRepository
    {
        private readonly MySqlConnection _connection;

        public MySqlTodoRepository(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
        }

        public void AddTodoItem(string todo)
        {
            _connection.Open();
            var command = new MySqlCommand("INSERT INTO Todo (Item) VALUES (@item)", _connection);
            command.Parameters.AddWithValue("@item", todo);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void RemoveTodoItem(int id)
        {
            _connection.Open();
            var command = new MySqlCommand("DELETE FROM Todo WHERE Id = @id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public List<string> GetTodoItems()
        {
            var items = new List<string>();
            _connection.Open();
            var command = new MySqlCommand("SELECT Item FROM Todo", _connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                items.Add(reader["Item"].ToString());
            }
            _connection.Close();
            return items;
        }
    }
}