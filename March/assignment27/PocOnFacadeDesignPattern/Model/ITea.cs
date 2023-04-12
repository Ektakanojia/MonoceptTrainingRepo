using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnFacadeDesignPattern.Model
{
    internal interface ITea
    {
        void GetBlackTea();
        void GetMasslaTea();

        void GetSugarFreeTea();
    }
}
