using SimpleInterfaceApp.Models;

namespace SimpleInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoDbOperations(new CustomerRepository()); //expects an object of a child class which implements interface
            DoDbOperations(new CountryRepository());
            DoDbOperations(new ProductRepository());
        }
        static void DoDbOperations(Icrudable crudable) //IsA,Polymorphic method
        {
            Console.WriteLine("Doing db Operations");
            crudable.Update();
            crudable.Create();
            crudable.Read();
            crudable.Delete();
        }
    }
}
