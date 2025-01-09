using CircleAbstractionApp.Models;

namespace CircleAbstractionApp
{
     class CircleTest
    {
        static void Main()
        {
            Circle SmallCircle = new Circle();
            SmallCircle.Radious = 5;
            Console.WriteLine($"SmallCircle: Radious = {SmallCircle.Radious} Area= {SmallCircle.CalculateArea()}");

            Circle BigCircle = new Circle();
            BigCircle.Radious = 10;
            Console.WriteLine($"BigCircle: Radious={BigCircle.Radious} Area={BigCircle.CalculateArea()}");
        }
    }
}
