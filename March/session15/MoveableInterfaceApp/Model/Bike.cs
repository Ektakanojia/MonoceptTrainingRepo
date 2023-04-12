using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveableInterfaceApp.Model
{
    internal class Bike:IMoveable
    {
        private string _name;

        public Bike( string name) 
        { 
        _name= name;
        }

        public void Move()
        {
            Console.WriteLine("Bike is moving  : " + _name);
        }
    }
}
