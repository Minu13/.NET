using GenericNodeClassApp.Models;
using Microsoft.Win32.SafeHandles;

namespace GenericNodeClassApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<Employee> firstEmployee = new Node<Employee>(new Employee("Minu", 1));
            Node<Employee> secondEmployee = new Node<Employee>(new Employee("Deepa", 2));
            Node<Employee> thirdEmployee = new Node<Employee>(new Employee("Mathi", 3));
            Node<Employee> fourthEmployee = new Node<Employee>(new Employee("Markonda", 4));
            Node<Employee> fifthEmployee = new Node<Employee>(new Employee("Maya", 5));

            firstEmployee.Next = secondEmployee;
            secondEmployee.Next = thirdEmployee;
            thirdEmployee.Next = fourthEmployee;
            fourthEmployee.Next = fifthEmployee;

            Node<Employee> current = firstEmployee;

            while (current != null)
            {
                Console.Write($"Employee ID: {current.Data.Id}, Name: {current.Data.Name}");

                if (current.Next != null)
                {
                    Console.Write($" -> Next Employee ID: {current.Next.Data.Id}, Name: {current.Next.Data.Name}");
                }
                Console.WriteLine();

                current = current.Next;
            }
        }

    }
}


