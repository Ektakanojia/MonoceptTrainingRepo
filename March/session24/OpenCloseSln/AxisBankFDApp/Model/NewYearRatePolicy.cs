using FixedDepositeCoreLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxisBankFDApp.Model
{
    public class NewYearRatePolicy : IRatePolicy
    {
        public double CalculateRate()
        {
            return .07;
        }
    }
}
