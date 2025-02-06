namespace CustomerCommonLib
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Adress> Addressess { get; private set; }

        public Customer() { 
        Addressess = new List<Adress>();
        }

        public void AddAddress(Adress address) { 
        //validate address fields
        Addressess.Add(address);
        }
    }
}
