using MySql.Data.MySqlClient;
using TodoAppV3MySqlIntegration.Models;


namespace TodoAppV3MySqlIntegration
{
    public class Program
    {
        private const int AddTodo = 1;
        private const int RemoveTodo = 2;
        private const int DisplayTodo = 3;
        private const int ExitApp = 4;
        static void Main(string[] args)
        {
            var connectionString = "Server=127.0.0.1;Database=rrd_mysql;User ID=root;Password=root;";
            ITodoRepository todoRepository = new MySqlTodoRepository(connectionString);

            while (true)
            {
                DisplayMenu();
                var choiceInput = Console.ReadLine();
                ProcessInput(choiceInput, todoRepository);
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine($"{AddTodo}. Add TODO item");
            Console.WriteLine($"{RemoveTodo}. Remove TODO item");
            Console.WriteLine($"{DisplayTodo}. Display TODO list");
            Console.WriteLine($"{ExitApp}. Exit");
        }

        static void ProcessInput(string choiceInput, ITodoRepository todoRepository)
        {
            if (!int.TryParse(choiceInput, out int choice))
            {
                DisplayInvalidInput();
                return;
            }

            ProcessChoice(choice, todoRepository);
        }

        static void ProcessChoice(int choice, ITodoRepository todoRepository)
        {
            if (choice == AddTodo)
            {
                AddTodoItem(todoRepository);
                return;
            }

            if (choice == RemoveTodo)
            {
                RemoveTodoItem(todoRepository);
                return;
            }

            if (choice == DisplayTodo)
            {
                DisplayTodoList(todoRepository);
                return;
            }

            if (choice == ExitApp)
            {
                ExitApplication();
                return;
            }

            DisplayInvalidChoice();
        }

        static void AddTodoItem(ITodoRepository todoRepository)
        {
            Console.WriteLine("Enter a TODO item:");
            var todoItem = Console.ReadLine();
            todoRepository.AddTodoItem(todoItem);
            Console.WriteLine("TODO item added.");
        }

        static void RemoveTodoItem(ITodoRepository todoRepository)
        {
            Console.WriteLine("Enter ID of TODO item to remove:");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                todoRepository.RemoveTodoItem(id);
                Console.WriteLine("TODO item removed.");
                return;
            }
            Console.WriteLine("Invalid ID. Please enter a numeric value.");
        }

        static void DisplayTodoList(ITodoRepository todoRepository)
        {
            Console.WriteLine("TODO list:");
            List<string> todoItems = todoRepository.GetTodoItems();
            foreach (var item in todoItems)
            {
                Console.WriteLine(item);
            }
        }

        static void ExitApplication()
        {
            Console.WriteLine("Exiting...");
            Environment.Exit(0);
        }

        static void DisplayInvalidInput()
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }

        static void DisplayInvalidChoice()
        {
            Console.WriteLine("Invalid choice. Please select a valid option.");
        }
    }
}
