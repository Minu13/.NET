using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppV3withDatabaseIntegration.Models
{
    public class TodoManager
    {
        private readonly ITodoStorage _storage;

        public TodoManager(ITodoStorage storage)
        {
            _storage = storage;
        }

        public string AddTodo()
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

            var newTodo = new Todo(description, priority);
            _storage.Add(newTodo);

            return "Todo added successfully!";
        }

        public List<string> GetTodos()
        {
            List<string> todoStrings = new List<string>();
            var todos = _storage.GetAll();

            foreach (var todo in todos)
            {
                todoStrings.Add(todo.ToString());
            }

            return todoStrings;
        }
    }

}
