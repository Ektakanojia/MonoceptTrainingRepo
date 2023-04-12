using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPVoliationApp.Model
{
    internal class Square:Rectangle
    {
        public Square(int side):base(side,side) { }

        public override void SetWidth(int pWidth)
        {
            _width = _height = pWidth;
        }
        public override void SetHeight(int pheight)
        {
            _width = _height = pheight;
        }
    }
}
