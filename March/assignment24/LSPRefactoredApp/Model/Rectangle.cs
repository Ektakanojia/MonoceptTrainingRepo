using LSPRefactoredApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPVoliationApp.Model
{
    public class Rectangle:IPolygon
    {
        protected int width;
        protected int height;

        public Rectangle(int _width, int _height)
        {
            width= _width;
            height= _height;
        }
       

        public virtual void SetWidth(int _width)
        {
            width = _width;
        }
        public virtual void SetHeight(int _height) 
        { 
            height = _height; 
        }
        public int GetWidth()
        {
            return width;
        }
        public int GetHeight()
        {
            return height;
        }

        public double CalculateArea()
        {
           return (double)width * (double)height;
        }
    }
}
