using SimpleIterateDesignPatternApp.Models;

namespace SimpleIterateDesignPatternApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyNamesCollection namesCollection = new MyNamesCollection();

            namesCollection.AddName("Maya");
            namesCollection.AddName("Mathi");
            namesCollection.AddName("Minu");

            MyNamesIterator iterator = namesCollection.GetIterator();

            while (iterator.HasNext())
            {
                string name = iterator.Next();
                Console.WriteLine(name);
            }

        }
    }
}