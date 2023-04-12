using MoveableInterfaceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImoveableRefactoredApp.Model
{
    abstract class Vechial:IMoveable
    {
        public string _name;

        public Vechial(string name)
        {
            _name = name;
        }
        public string Name { get { return _name;} }

        public abstract void Move();
    }
}
