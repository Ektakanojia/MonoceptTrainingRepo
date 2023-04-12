using LSPRefactoredApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPVoliationApp.Model
{
    internal class Square:IPolygon
    {

        int _side;

        
        public Square(int side) 
        { 
        _side= side;
        }
        public double CalculateArea()
        {
            return _side * _side;
        }
    }
}
