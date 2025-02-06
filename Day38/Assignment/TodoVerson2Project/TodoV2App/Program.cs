using TodooCommonLib.Model;

namespace TodoV2App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TodoManager todoManager = new TodoManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("1. Add Todo");
                Console.WriteLine("2. Display Todos");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    todoManager.AddTodo();
                    Console.WriteLine("Todo added successfully!\n");
                }
                else if (choice == "2")
                {
                    DisplayTodos(todoManager.GetTodos());
                }
                else if (choice == "3")
                {
                    exit = true;
                }

                if (choice != "1" && choice != "2" && choice != "3")
                {
                    Console.WriteLine("Invalid choice, please try again.\n");
                }
            }

            Console.WriteLine("Thank you for using the Todo app.");
        }

        static void DisplayTodos(List<Todo> todos)
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("No todos to display.\n");
                return;
            }

            Console.WriteLine("Todos:");
            foreach (var todo in todos)
            {
                Console.WriteLine(todo.ToString());
            }
            Console.WriteLine($"Total Todos: {todos.Count}\n");
        }
    }
    }

