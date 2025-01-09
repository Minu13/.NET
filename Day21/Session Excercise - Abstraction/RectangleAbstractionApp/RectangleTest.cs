using RectangleAbstractionApp.Models;

namespace RectangleAbstractionApp
{
    class RectangleTest
    {
        static void Main()
        {
            Rectangle SmallRectangle = new Rectangle();
            SmallRectangle.height = 10;
            SmallRectangle.width = 5;
            Console.WriteLine($"SmallRectangle: height ={SmallRectangle.height}, width={SmallRectangle.width},Area={SmallRectangle.calculateArea()}");

            Rectangle BigRectangle = new Rectangle();
            BigRectangle.height = 15;
            BigRectangle.width = 20;
            Console.WriteLine($"BiglRectangle: height ={BigRectangle.height}, width={BigRectangle.width},Area={BigRectangle.calculateArea()}");
        }
    }
}
