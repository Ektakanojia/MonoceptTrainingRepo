using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPVoliationApp.Model
{
    internal class FixedDeposite
    {
        private int _accno;
        private string _name;
        private double _pricipleAmount;
        private int _duration;
        FestivleType _festivle;

        public FixedDeposite(int accno, string name, double prinicpleAmount, int duration, FestivleType festivle)
        {
            _accno = accno;
            _name = name;
            _pricipleAmount = prinicpleAmount;
            _duration = duration;
            _festivle = festivle;

        }
        public double CalculateRate()
        {
            if (_festivle == FestivleType.DIWALI)
                return .09;
            else if (_festivle == FestivleType.NEWYEAR)
                return .08;
            else
                return .07;
        }
        public double SimpleIntrest
        {
            get
            {
                return _pricipleAmount* _duration*CalculateRate();
            }
        }

    }
}
