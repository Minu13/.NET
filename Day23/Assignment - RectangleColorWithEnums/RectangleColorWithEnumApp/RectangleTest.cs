

using RectangleColorWithEnumApp.Models;
using RectnagleWithPropertiesApp.Models;

namespace RectangleColorWithEnumApp
{
     class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Width = 10;
            r1.Height = 30;
            r1.ColorStyle = ColorOptions.Blue;
            

            Rectangle r2 = new Rectangle();
            r2.Width = 20;
            r2.Height = 30;
            r2.ColorStyle = ColorOptions.Yellow;


            Rectangle r3 = new Rectangle();
            r3.Width = 30;
            r3.Height = 40;
           r3.ColorStyle = ColorOptions.Green;



            Rectangle[] manyRectangles = new Rectangle[3];
            manyRectangles[0] = r1;
            manyRectangles[1] = r2;
            manyRectangles[2] = r3;

            PrintDetails(manyRectangles);

        }

        private static void PrintDetails(Rectangle[] manyRectangles)
        {
            foreach (Rectangle rectangle in manyRectangles)
            {
                PrintDetails("manyRectangles", rectangle);
            }
        }

        private static void PrintDetails(string details, Rectangle rectangle)
        {
            Console.WriteLine($"wdith {rectangle.Width} , height is {rectangle.Height}, Area is {rectangle.Area} ,borer is {rectangle.ColorStyle}");
            Console.WriteLine();
            Console.ResetColor();

        }
    }
    }

