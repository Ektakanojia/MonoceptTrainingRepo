using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddApp.Model
{
    internal class FindEvenOdd
    {

        private int _oddNumber;
        private int _evenNumber;
        int[] Array = new int[100];
        public void FindOdd(int range)
        {
            for (int i = 1; i <= range; i++)
            {
                if (i % 2 != 0)
                {
                    _oddNumber = i;
                    Console.WriteLine(_oddNumber);
                }
            }
        }
        public void FindEven(int range)
        {

            for (int i = 1; i <= range; i++)
            {
                if (i % 2 == 0)
                {
                    _evenNumber = i;
                    Console.WriteLine(_evenNumber);
                }
            }

        }
        public void GetOdd(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    _oddNumber = i;

                    Console.WriteLine(_oddNumber);

                }
            }
        }
        public void GetEven(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    _evenNumber = i;
                    Console.WriteLine(_evenNumber);
                }
            }
        }
       public  void  FindWhoIsEven(int[] _array)
        {
            int size=_array.Length;
            for(int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    _array[i] = i;
                }
            }
            
        }

       
    }
}
