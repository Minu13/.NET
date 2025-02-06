using CustomerCommonLib;

namespace CustomerSerializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Customer { Id = 1, Name = "Markonda" };
            c1.AddAddress(new Adress { city = "Chennai", country = "Inida" });
        }
    }
}
