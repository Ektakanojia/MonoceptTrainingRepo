using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnFacadeDesignPattern.Model
{
    public class RestrauntFacade
    {
        private IMaggie _MaggieProvider;
        private ITea _TeaProvider;

        public RestrauntFacade()
        {
            _MaggieProvider = new MaggieProvider();
            _TeaProvider = new TeaProvider();
        }

        public void GetPlainMaggie()
        {
            _MaggieProvider.GetPlainMaggie();
        }
        public void GetTea()
        {
            _TeaProvider.GetBlackTea();
        }
    }
}
