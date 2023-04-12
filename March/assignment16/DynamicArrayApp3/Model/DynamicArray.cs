using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayApp3.Model
{
    internal class DynamicArray
    {
        public int[] GetArrayElement(int size)
        {

            int[] monoceptDynamicArray = new int[size];
            string num;
            int ele;
            for (int i = 0; i < monoceptDynamicArray.Length; i++)
            {
                Console.WriteLine("Enter array element");
                num = Console.ReadLine();
                ele = int.Parse(num);
                monoceptDynamicArray[i] = ele;
            }
          
            return monoceptDynamicArray;
        }

      

        public int[] GetTheDoubleSizeArray(int size)
        {
            size = size * 2;
            int[] resizedMonoceptDynamicArray = new int[size];
            int ele;
            string num;
            for (int i = size / 2; i < size; i++)
            {
                Console.WriteLine("Enter array element");
                num = Console.ReadLine();
                ele = int.Parse(num);
                resizedMonoceptDynamicArray[i] = ele;
            }
           
            return resizedMonoceptDynamicArray;
        }

       

       

    }
    
}
