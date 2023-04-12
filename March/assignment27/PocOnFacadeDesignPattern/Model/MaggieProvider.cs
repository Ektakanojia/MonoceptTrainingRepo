using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnFacadeDesignPattern.Model
{
    internal class MaggieProvider : IMaggie
    {
        public void GetMasalaMaggie()
        {
            Console.WriteLine("Getting masal Maggie");
        }

        public void GetPlainMaggie()
        {
            GetExtraVeggies();
            Console.WriteLine("Getting plain maggie");
        }

        public void GetExtraVeggies()
        {
            Console.WriteLine("Getting extra veggies");
        }
    }
}
