using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TodooCommonLib.Model
{

    public class TodoManager
    {
        private List<Todo> _todos = new List<Todo>();
        private static readonly string DirectoryPath = @"C:\temp";
        private static readonly string FilePath = Path.Combine(DirectoryPath, "todos.json");

        public TodoManager()
        {
            Load();
        }

        public void AddTodo()
        {
            Console.Write("Enter description: ");
            string description = Console.ReadLine();

            Console.Write("Enter priority (High, Medium, Low): ");
            string priority = Console.ReadLine();

            while (priority != "High" && priority != "Medium" && priority != "Low")
            {
                Console.Write("Invalid input. Enter priority (High, Medium, Low): ");
                priority = Console.ReadLine();
            }

            Todo newTodo = new Todo(description, priority);
            _todos.Add(newTodo);
            Save();
        }

        public List<Todo> GetTodos()
        {
            return _todos;
        }

        private void Save()
        {
            string jsonString = JsonSerializer.Serialize(_todos);
            File.WriteAllText(FilePath, jsonString);
        }

        private void Load()
        {
            if (File.Exists(FilePath))
            {
                string jsonString = File.ReadAllText(FilePath);
                _todos = JsonSerializer.Deserialize<List<Todo>>(jsonString) ?? new List<Todo>();
            }
        }

    }
}

