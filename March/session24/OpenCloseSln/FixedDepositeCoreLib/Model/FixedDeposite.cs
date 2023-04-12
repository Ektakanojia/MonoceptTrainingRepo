using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedDepositeCoreLib.Model
{
     public class FixedDeposite
    {
        private int _accno;
        private string _name;
        private double _pricipleAmount;
        private int _duration;
        IRatePolicy _ratePolicy;

        public FixedDeposite(int accno, string name, double prinicpleAmount, int duration, IRatePolicy ratePolicy)
        {
            _accno = accno;
            _name = name;
            _pricipleAmount = prinicpleAmount;
            _duration = duration;
            _ratePolicy = ratePolicy;

        }
       
        public double SimpleIntrest
        {
            get
            {
                return _pricipleAmount* _duration*_ratePolicy.CalculateRate();
            }
        }

    }
}
