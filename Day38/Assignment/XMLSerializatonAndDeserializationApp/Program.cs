using System.Xml.Serialization;
using XMLSerializatonAndDeserializationApp.Model;

namespace XMLSerializatonAndDeserializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SerializeToXml();
            DeserializeFromXml();
        }

        private static void SerializeToXml()
        {
            var customer = new Customer

            {Id = 1,Name = "Maya",Addresses = new List<Address>
            {
                new Address { City = "Trivandrum", Country = "India" },
                new Address { City = "Thrissur", Country = "India" }
            }
            };

            var xmlSerializer = new XmlSerializer(typeof(Customer));
            var sw = new StreamWriter(@"C:\temp\customer.xml");
            xmlSerializer.Serialize(sw, customer);
            sw.Close();
            Console.WriteLine("Serialized to XML and written to file");
        }

        private static void DeserializeFromXml()
        {
            var xmlSerializer = new XmlSerializer(typeof(Customer));
            var sr = new StreamReader(@"C:\temp\customer.xml");
            var customer = (Customer)xmlSerializer.Deserialize(sr);
            sr.Close();

            Console.WriteLine($"Id: {customer.Id}");
            Console.WriteLine($"Name: {customer.Name}");
            foreach (var address in customer.Addresses)
            {
                Console.WriteLine($"City: {address.City}, Country: {address.Country}");
            }
            Console.WriteLine("Read from XML file and deserialized");

        }
    }
}
