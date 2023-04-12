using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEventApp.Model
{
     public delegate void DOperationNotifier(int num1,int num2,string res);
    internal class Calculator
    {


        private int result;
        public event DOperationNotifier OnAdditionCompleted ;
        public event DOperationNotifier OnSubstractionCompleted ;
       
        
        public  void Add(int num1,int num2)
        {
             result= num1+num2;
              string res = $"Addtion is :{result}";
            if (OnAdditionCompleted != null)
            {
               OnAdditionCompleted(num1, num2,res);
            }
            
        }
        public void Substract(int num1,int num2)
        {
            result = num2 - num1;
            string res = $"Substraction is : {result}";
            if(OnSubstractionCompleted!= null)
            {
                OnSubstractionCompleted(num1, num2,res);
            }
           
        }

    }
}
