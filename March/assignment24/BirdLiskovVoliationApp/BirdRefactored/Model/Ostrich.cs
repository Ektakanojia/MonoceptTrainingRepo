using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdRefactored.Model
{
    internal class Ostrich : IBirdCanFly
    {
        public Ostrich(string name) { Name = name; }
        public string Name { get ; set ; }

        public bool CanFly()
        {
            return false;
        }
    }
}
