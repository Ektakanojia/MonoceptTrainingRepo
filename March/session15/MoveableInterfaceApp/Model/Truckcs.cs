using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveableInterfaceApp.Model
{
    internal class Truckcs:IMoveable
    {

        private string _name;

        public Truckcs( string name) 
        { 
         _name= name;
        
        }

        public void Move()
        {
            Console.WriteLine("Truck is Moving : " + _name);
        }
    }
}
