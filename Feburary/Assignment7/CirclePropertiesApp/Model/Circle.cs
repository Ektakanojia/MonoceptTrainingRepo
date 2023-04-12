using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePropertiesApp.Model
{
    internal class Circle
    {
        private float _radius;
        private string _borderStyle;
        private string _color;
        public Circle(float radius, string borderStyle, string color)
        {
            _radius = ValidateRadius(radius);
            _borderStyle = ValidateBorderStyle(borderStyle);
            _color = ValidateColor(color);

        }
        private float ValidateRadius(float radius)
        {
            if (radius > 10)
                return 10;
            else if (radius < 0) 
                return 0;
            else 
                return radius;
        }

        private string ValidateBorderStyle(string borderStyle)
        {
            borderStyle= borderStyle.ToLower();
           if(borderStyle == "dottedline" || borderStyle == "singleline" || borderStyle == "doubleline")
            {
                return borderStyle;
            }
            else
            {
                return "singleline";
            }
        }
        private string ValidateColor(string color)
        {
            color= color.ToLower();
            if(color == "red" || color == "green" || color == "blue")
            {
                return color;
            }
            else
            {
                return "red";
            }

        }

        public float Radius
        {
            get
            {
                return _radius;
            }
        }
        public string BorderStyle
        {
            get
            {
                return _borderStyle;
            }
            set
            {
                _borderStyle = ValidateBorderStyle(value);
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = ValidateColor(value);
            }
        }
    }
}
