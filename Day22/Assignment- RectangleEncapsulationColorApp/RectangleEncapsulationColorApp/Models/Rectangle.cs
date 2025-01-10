namespace RectangelEncapsulationREfacotred.Models
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private string _color;

        private const int MIN_DIMENSION = 1;
        private const int MAX_DIMENSION = 100;
        private static readonly string[] VALID_COLORS = { "Red", "Green", "Blue" };

        public Rectangle(int width, int height, string color)
        {
            _width = CorrectTheDimension(width);
            _height = CorrectTheDimension(height);
            SetColor(color); 
        }

        public int CalculateArea()
        {
            return _width * _height;
        }

        public void SetWidth(int pwidth)
        {
            _width = CorrectTheDimension(pwidth);
        }

        public int GetWidth()
        {
            return _width;
        }

        public void SetHeight(int pheight)
        {
            _height = CorrectTheDimension(pheight);
        }

        public int GetHeight()
        {
            return _height;
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

        public void SetColor(string color)
        {
            if (Array.Exists(VALID_COLORS, validColor => validColor.Equals(color, StringComparison.OrdinalIgnoreCase)))
            {
                _color = color;
            }
        }

        public string GetColor()
        {
            return _color;
        }
    }
}
