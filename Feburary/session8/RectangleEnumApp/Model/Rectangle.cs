using System;
namespace RectangleEnumApp.Model
{
    internal class Rectangle
    {
        private readonly int _width;
        private  readonly int _height;
       
        private ColorOption _color;
        private BorderOptioncs _border;

        //constructor
        public Rectangle(int width, int height, ColorOption color)
        {
            _width = ValidateSide(width);
            _height = ValidateSide(height);
            _color = color;
        }
        //constructor overloading
        public Rectangle(int width, int height, ColorOption color, BorderOptioncs border)
        {
            _width = ValidateSide(width);
            _height = ValidateSide(height);
            _color =  color;
            _border =  border;
        }
        private int ValidateSide(int side)
        {
            if (side > 100)
                return 100;
            else if (side < 0)
                return 1;
            else
                return side;
        }
        private string ValidateColor(string color)
        {
            if (color.ToLower() == "red" || color.ToLower() == "green" || color.ToLower() == "yellow")
                return color;
            else
                return "red";
        }
        public int Width
        {
            get 
            { 
                return _width; 
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
           
        }
        public ColorOption Color
        {
            get
            {
                return _color;
            }
           
        }
        public BorderOptioncs Border
        {
            get
            {
                return _border;
            }

        }
    }
}
