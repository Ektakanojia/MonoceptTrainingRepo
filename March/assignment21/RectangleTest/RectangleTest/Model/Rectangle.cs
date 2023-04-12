
using System;


namespace RectangleApp.Model
{
    public class Rectangle
    {
        private int rectangleWidth;
        private int rectangleHeight;
        private string rectangleColor;

        public Rectangle(int _recWidth,int _recHeight,string _recColor)
        {
            rectangleColor= _recColor;
            rectangleWidth= _recWidth;
            rectangleHeight= _recHeight;
        }

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
        public int CalculateArea(int width,int height)
        {

            int area = width* height;
            return area;
        }
    }
}
