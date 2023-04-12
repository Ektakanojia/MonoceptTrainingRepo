using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace LSPVoliationApp.Model
{
     public  class Square:Rectangle
    {
        protected int side;
        public Square(int side):base(side,side) { }

        public override void SetWidth(int _pWidth)
        {
            width = height= _pWidth;
        }
        public override void SetHeight(int _pheight)
        {
            width = height = _pheight;
        }
    }
}
