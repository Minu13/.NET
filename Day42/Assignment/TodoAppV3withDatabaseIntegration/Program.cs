using TodoAppV3withDatabaseIntegration.Models;

namespace TodoAppV3withDatabaseIntegration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            ITodoStorage storage = new DatabaseTodoStorage(connectionString);
            var todoManager = new TodoManager(storage);
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

        static void DisplayTodos(List<string> todoStrings)
        {
            if (todoStrings.Count == 0)
            {
                Console.WriteLine("No todos to display.\n");
                return;
            }

            Console.WriteLine("Todos:");
            foreach (var todo in todoStrings)
            {
                Console.WriteLine(todo.ToString());
            }
            Console.WriteLine($"Total Todos: {todoStrings.Count}\n");
        }
    }

}


