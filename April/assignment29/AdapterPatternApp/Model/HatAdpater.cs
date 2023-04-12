using AdpaterExternalLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp.Model
{
    internal class HatAdpater : Item
    {
        private Hat _hat;

        public HatAdpater(Hat hat)
        {
            _hat = hat;
        }
        public string Name()
        {
            return _hat.getShortName;
        }

        public double Price()
        {
            return _hat.getPrice;
        }
    }
}
