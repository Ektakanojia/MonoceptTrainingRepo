using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CalculateExceptionApp.Model
{
    internal class NegativeNumberNotSupportedException:Exception
    {
        private int _firstNumber;
        private int _secondNumber;

        public NegativeNumberNotSupportedException(int firstNumber,int secondNumber)
        {
            _firstNumber= firstNumber;
            _secondNumber= secondNumber;
        }
        
        public override string Message
        {
            get
            {
                string template = "";
                template += "firstno :" + _firstNumber;
                template += "secondno :" + _secondNumber;
                template += "Negative Numbers are not allowed";
                return template;
            }
        }
    }
}
