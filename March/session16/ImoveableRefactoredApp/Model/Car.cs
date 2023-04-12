using ImoveableRefactoredApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveableInterfaceApp.Model
{
    internal class Car: Vechial
    {
        public Car(string name) : base(name)
        {
        }

        public  override void Move()
        {
            Console.WriteLine("Car is moving  : "+ _name);
        }

      
    }
}
