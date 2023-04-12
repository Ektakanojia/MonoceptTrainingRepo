
using System;


namespace RectangleApp.Model
{
    internal class Rectangle
    {
        private int rectangleWidth;
        private int rectangleHeight;
        private string rectangleColor;

        public void SetWidth(int width)
        {
            if (width > 100)
                rectangleWidth = width;
            else if (width < 0)
                rectangleWidth = 1;
            else
                rectangleWidth = width;
        }
        public int GetWidth() { return rectangleWidth; }
        public void SetHeight(int height)
        {
            if (height > 100)
                height = 100;
            else if (height < 0)
            {
                rectangleHeight = 1;
            }
            else
                rectangleHeight = height;

        }
        public int GetHeight()
        {
            return rectangleHeight;
        }
        public void SetColor(string color)
        {
            if (color.ToLower() == "red" || color.ToLower() == "green" || color.ToLower() == "yellow")
                rectangleColor = color;
            else
                rectangleColor = "red";
        }
        public string GetColor() { return rectangleColor; }
        public int CalculateArea()
        {
            int area = rectangleWidth * rectangleHeight;
            return area;
        }
    }
}
