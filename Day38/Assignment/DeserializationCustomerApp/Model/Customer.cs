namespace CustomerCommonLib
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Address> Addressess { get; private set; }

        public Customer() { 
        Addressess = new List<Address>();
        }

        public void AddAddress(Address address) { 
        //validate address fields
        Addressess.Add(address);
        }
    }
}
