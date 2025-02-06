using CustomerCommonLib;
using System.Text.Json;

namespace DeserializationCustomerApp
{
    internal class Program
    {
        static void Main(string[] args)
        
            {
                DeserializeFromJson();
            }

    private static void DeserializeFromJson()
        {
            string filePath = @"C:\temp\cust1.json";
            string jsonString = File.ReadAllText(filePath);

            Customer customer = JsonSerializer.Deserialize<Customer>(jsonString);

            Console.WriteLine($"Id: {customer.Id}");
            Console.WriteLine($"Name: {customer.Name}");
            foreach (var address in customer.Addressess)
            {
                Console.WriteLine($"City: {address.City}, Country: {address.Country}");
            }
            Console.WriteLine("read from file and deserialized");
        }

    }
    }

