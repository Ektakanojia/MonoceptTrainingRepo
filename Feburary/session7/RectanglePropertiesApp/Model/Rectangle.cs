
using System;


namespace RectangleApp.Model
{
    internal class Rectangle
    {
        private readonly int rectangleWidth;
        private  readonly int rectangleHeight;
        //private readonly object set;
        private string rectangleColor;
        //private object get;

        //constructor
        public Rectangle(int width, int height, string color)
        {
            rectangleWidth = ValidateSide(width);
            rectangleHeight = ValidateSide(height);
            rectangleColor = ValidateColor(color);


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
                return rectangleWidth; 
            }
        }
        public int Height
        {
            get
            {
                return rectangleHeight;
            }
           
        }
        public string Color
        {
            get
            {
                return rectangleColor;
            }
            set
            {
                rectangleColor = ValidateColor(value);
            }
        }
    }
}
