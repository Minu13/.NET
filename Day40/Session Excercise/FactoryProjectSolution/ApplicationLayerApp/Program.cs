using AutoFactoryCommonLib.Products;

namespace ApplicationLayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new AutomobileFacory();
            IAutoMobile auto = factory.Make(AutoType.AUDI);
            auto.Start();
            auto.Stop();
            Console.WriteLine(auto.GetType());
        }
    }
}
