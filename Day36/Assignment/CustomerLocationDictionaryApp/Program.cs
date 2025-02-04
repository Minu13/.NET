using CustomerLocationDictionaryApp.Models;

namespace CustomerLocationDictionaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Deepa", Location = "Chennai" },
            new Customer { Id = 2, Name = "Mathi", Location = "Trivandrum" },
            new Customer { Id = 3, Name = "Markonda", Location = "Chennai" },
            new Customer { Id = 4, Name = "Sachin", Location = "Delhi" },
            new Customer { Id = 5, Name = "Minu", Location = "Trivandrum" }
        };
                        
            Dictionary<string, List<Customer>> groupedCustomers = GroupCustomersByLocation(customers);
                        
            DisplayGroupedCustomers(groupedCustomers);
        }

        private static Dictionary<string, List<Customer>> GroupCustomersByLocation(List<Customer> customers)
        {
            var map = new Dictionary<string, List<Customer>>();

            foreach (Customer customer in customers)
            {
                if (!map.ContainsKey(customer.Location))
                {
                    map.Add(customer.Location, new List<Customer>());
                }
                map[customer.Location].Add(customer);
            }

            return map;
        }
        private static void DisplayGroupedCustomers(Dictionary<string, List<Customer>> groupedCustomers)
        {
            foreach (var group in groupedCustomers)
            {
                Console.WriteLine($"Location: {group.Key}");
                foreach (var customer in group.Value)
                {
                    Console.WriteLine($"  Id: {customer.Id}, Name: {customer.Name}");
                }
            }
        }
    }
}

