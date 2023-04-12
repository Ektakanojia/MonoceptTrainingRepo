using MoveableInterfaceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveableInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMoveable[] moveablesArray = new IMoveable[3];
            moveablesArray[0] = new Car("Audi");
            moveablesArray[1] = new Bike("Pulsar");
            moveablesArray[2] = new Truckcs("Ashokley land");
            StartRace(moveablesArray);

        }

        public static void StartRace(IMoveable[] moveables)
        {
            Console.WriteLine("start Race");
            foreach (IMoveable moveable in moveables)
            {
                moveable.Move();
            }

            Console.WriteLine("Race End");

        }
    }
}
