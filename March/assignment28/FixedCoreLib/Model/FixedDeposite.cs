using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedDepositeCoreLib.Model
{
     public delegate double DCalculateRate();
     public class FixedDeposite
    {
        private int _accno;
        private string _name;
        private double _pricipleAmount;
        private int _duration;
        private DCalculateRate _calculateRate;

        public FixedDeposite(int accno, string name, double prinicpleAmount, int duration, DCalculateRate calculateRate)
        {
            _accno = accno;
            _name = name;
            _pricipleAmount = prinicpleAmount;
            _duration = duration;
            _calculateRate = calculateRate;

        }
       
        public double SimpleIntrest
        {
            get
            {
                return _pricipleAmount* _duration*_calculateRate();
            }
        }

    }
}
