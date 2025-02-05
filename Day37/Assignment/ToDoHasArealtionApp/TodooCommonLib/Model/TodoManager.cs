using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodooCommonLib.Model
{
   
public class TodoManager
    {
        private List<Todo> _todos = new List<Todo>();

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
        }

        public List<Todo> GetTodos()
        {
            return _todos;
        }
    }

}

