
using System;
namespace RectangleApp.Model
{
    internal class Rectangle
    {
        private readonly int rectangleWidth;
        private readonly int rectangleHeight;
        private string rectangleColor;
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

        public string GetColor() { return rectangleColor; }
        public void SetColor(string color)
        {
            color= ValidateColor(color);
        }
        public int GetWidth()
        {
            return rectangleWidth;
        }
        public int GetHeight()
        {
            return rectangleHeight;
        }
    }
}
