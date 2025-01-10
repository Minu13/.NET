using RectangelEncapsulationREfacotred.Models;

namespace RectangleEncapsulationColorApp
{
    class RectangleTest
    {
        static void Main()
        {
            Rectangle[] rectangles = new Rectangle[3];
            rectangles[0] = new Rectangle(10, 20, "Red");
            rectangles[1] = new Rectangle(50, 70, "Green");
            rectangles[2] = new Rectangle(30, 40, "Blue");

            foreach (Rectangle rect in rectangles)
            {
                PrintInfo("Rectangle", rect);
            }

            Rectangle largestRectangle = FindLargestRectangle(rectangles);
            PrintInfo("Largest Rectangle", largestRectangle);
        }

        static void PrintInfo(string info, Rectangle anyRectangle)
        {
            Console.WriteLine("Displaying info of " + info);
            Console.WriteLine($"Width: {anyRectangle.GetWidth()}");
            Console.WriteLine($"Height: {anyRectangle.GetHeight()}");
            Console.WriteLine($"Area: {anyRectangle.CalculateArea()}");
            Console.WriteLine($"Color: {anyRectangle.GetColor()}");
                   }

        static Rectangle FindLargestRectangle(Rectangle[] rectangles)
        {
            Rectangle largest = rectangles[0];
            foreach (Rectangle rect in rectangles)
            {
                if (rect.CalculateArea() > largest.CalculateArea())
                {
                    largest = rect;
                }
            }
            return largest;
        }
    }

}
