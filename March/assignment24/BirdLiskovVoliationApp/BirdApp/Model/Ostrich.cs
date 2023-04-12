using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdApp.Model
{
    internal class Ostrich:Bird
    {
        public Ostrich(string name) : base(name)
        {
        }

        public override string Fly()
        {
            return ("I am ostrich and I cannot Fly");
        }
    }
}
