using System;

namespace CircleApp.Model
{
    internal class Circle
    {
        private float radius;
        private string borderStyle;
        private string color;
        public void SetRadius(float circleRadius)
        {
            radius = circleRadius;
        }
        public float GetRadius()
        {
            return radius;
        }
        public void SetBorderStyle(string circleBorderStyle)
        {
            if (circleBorderStyle == "singleline" || circleBorderStyle == "doubleline" || circleBorderStyle == "dottedline")
            {
                borderStyle = circleBorderStyle;
            }
            else
            {
                borderStyle = "null";
            }

        }
        public string GetBorderStyle()
        {
            return borderStyle;
        }
        public void SetColor(string circleColor)
        {
            if (circleColor.ToLower() == "red" || circleColor.ToLower() == "blue" || circleColor.ToLower() == "green")
            {
                color = circleColor;
                
            }
            else
            {
                color = "null";
            }
        }
        public string GetColor()
        {
            return color;
        }

    }
}
