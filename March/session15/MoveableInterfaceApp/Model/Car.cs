﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveableInterfaceApp.Model
{
    internal class Car:IMoveable
    {
        private string _name;

        public Car(string name) 
        {
        _name= name;
        }

        public void Move()
        {
            Console.WriteLine("Car is moving  : "+ _name);
        }
    }
}
