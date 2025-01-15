using RectangleColorWithEnumApp.Models;
using System;
namespace RectnagleWithPropertiesApp.Models
{
    class Rectangle
    {
        //fields

        private int _width;
        private int _height;
        private ColorOptions _colorStyle;

        private const int MIN_DIMENSION = 1;
        private const int MAX_DIMENSION = 100;





        //properties

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = CorrectTheDimension(value);

            }

        }

        public int Height
        {

            get
            {
                return _height;
            }
            set
            {
                _height = CorrectTheDimension(value);
            }

        }

        public int Area
        {

            get
            {
                return _width * _height;
            }
        }


        public ColorOptions ColorStyle
        {
            get
            {
                return _colorStyle;
            }
            set
            {
                _colorStyle = value;
            }
        }


        private int CorrectTheDimension(int dimension)
        {
            if (dimension < MIN_DIMENSION)
            {
                return MIN_DIMENSION;
            }

            if (dimension > MAX_DIMENSION)
            {
                return MAX_DIMENSION;
            }

            return dimension;

        }
    }
}