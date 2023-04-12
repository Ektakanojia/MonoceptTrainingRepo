using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdpaterExternalLib
{
     public class Hat
    {
        private string _shortName;
        private string _longName;
        private double _basePrice;
        private double _Gst = .08;

        public Hat(string shortName,string longName,double basePrice,double Gst)
        {
            _shortName= shortName;
            _longName= longName;
            _basePrice= basePrice;
            _Gst = Gst;
        }
        public double getPrice
        {
            get
            {
                return _basePrice;
            }
        }

        public string getShortName
        {
            get
            {
                return _shortName;
            }
        }

        public string getLongName
        {
            get
            {
                return _longName;
            }
        }
    }
}
