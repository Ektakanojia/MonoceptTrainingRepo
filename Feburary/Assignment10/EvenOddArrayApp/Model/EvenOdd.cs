using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddArrayApp.Model
{
    internal class EvenOdd
    {

        public int[] GetEvenElement(int number)
        {
            int[] evenNumber= new int[number/2];
            int j = 0;
            for(int i=1;i<=number;i++)
            {
                if (i % 2 == 0)
                {
                    evenNumber[j] = i;
                    j++;
                }
                   
            }
            return evenNumber;
        }
        public int[] GetOddElement(int number)
        {
            int[] oddNumber = new int[number/2];
            int j = 0;
            for(int i=0;i<=number;i++)
            {
                if(i%2 !=0)
                {
                    oddNumber[j] = i;
                    j++;
                }
            }
            return oddNumber;
        }

        public int[] GetEvenElementInRange(int start,int end)
        {
            int range= end-start+1;
            int[] evenNumber= new int[range];
            int j = 0;
            for(int i=start;i<=end;i++)
            {
                if(i%2 ==0) 
                {
                    evenNumber[j] = i;
                    j++;
                }

            }
            return evenNumber;
        }

        public int[] GetOddElementInRange(int start, int end)
        {
            int range = end - start + 1;
            int[] oddNumber = new int[range];
            int j = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumber[j] = i;
                    j++;
                }

            }
            return oddNumber;
        }
    }
}
