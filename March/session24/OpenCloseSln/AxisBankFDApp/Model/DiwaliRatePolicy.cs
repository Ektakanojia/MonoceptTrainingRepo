using FixedDepositeCoreLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxisBankFDApp.Model
{
    public class DiwaliRatePolicy : IRatePolicy
    {
        public double CalculateRate()
        {
            return .06;
        }
    }
}
