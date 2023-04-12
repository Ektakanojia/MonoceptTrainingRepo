using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnFacadeDesignPattern.Model
{
    internal class TeaProvider : ITea
    {
        public void GetBlackTea()
        {
            Console.WriteLine("Getting black tea");
        }

        public void GetMasslaTea()
        {
            Console.WriteLine("Getting massal tea with elichi and ginger");
        }

        public void GetSugarFreeTea()
        {
            Console.WriteLine("Getting tea without sugar");
        }
    }
}
