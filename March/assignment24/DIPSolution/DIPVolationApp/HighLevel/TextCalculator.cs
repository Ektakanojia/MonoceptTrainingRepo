using DIPVolationApp.LowLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPVolationApp.HighLevel
{
    internal class TextCalculator
    {
        private ErrorLogOption logOption;

        public TextCalculator(ErrorLogOption eLogOption)
        {
            logOption = eLogOption;
        }

        public int CalculateTax(int income,int rate)
        {
            int result = -1;
            try
            {
                result = income/rate;
            }catch(Exception ex)
            {
                if (logOption == ErrorLogOption.TXT)
                {
                    var txtlogger = new TXTErrorLogger();
                    txtlogger.Log(ex);
                }
                else 
                {
                    var xmllogger = new XMLErrorLog();
                    xmllogger.Log(ex);
                }
            }

            return result;
        }
    }
}
