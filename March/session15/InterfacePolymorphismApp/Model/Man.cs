﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismApp.Model
{
    internal class Man : IMannerable
    {
        public void Depart()
        {
            Console.WriteLine(" Man is Depart");
        }

        public void Wish()
        {
            Console.WriteLine(" Man is Wish");
        }
    }
}
