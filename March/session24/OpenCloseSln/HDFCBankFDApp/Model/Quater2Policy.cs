using FixedDepositeCoreLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDFCBankFDApp.Model
{
    public class Quater2Policy : IRatePolicy
    {
        public double CalculateRate()
        {
            return .09;
        }
    }
}
