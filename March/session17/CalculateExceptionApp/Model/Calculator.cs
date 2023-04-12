using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateExceptionApp.Model
{
    internal class Calculator
    {
        private int _firstNumber;
        private int _secondNumber;


        public Calculator(int firstNumber, int secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }

        public   int Add(int firstNumber,int secondNumber)
        {
            if (firstNumber < 0 || secondNumber < 0)
            {
                if (firstNumber < 0)
                {
                    Console.WriteLine("firstnumber is negative" + _firstNumber);
                }
                else
                {
                    Console.WriteLine("second number is negative" + _secondNumber);
                }
                throw new NegativeValueNotSupportedException(_firstNumber, _secondNumber);
                
               
            }
            int num = firstNumber + secondNumber;
            return num;
            
        }
    }
}
