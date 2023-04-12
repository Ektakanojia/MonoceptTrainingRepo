using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPVoliationApp.Model
{
    public class Rectangle
    {
        protected int _width;
        protected int _height;

        public Rectangle(int width, int height)
        {
           _width= width;
            _height= height;
        }
        public int CalculateArea(int _area)
        {
            return _width * _height;
        }

        public virtual void SetWidth(int pwidth)
        {
            _width = pwidth;
        }
        public virtual void SetHeight(int pheight) 
        { 
            _height = pheight; 
        }
        public int GetWidth()
        {
            return _width;
        }
        public int GetHeight()
        {
            return _height;
        }
    }
}
