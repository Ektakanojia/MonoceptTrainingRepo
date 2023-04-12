using DynamicArrayApp3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DynamicArray dynamicArray = new DynamicArray();
            DynamicArray resizedDynamicArray = new DynamicArray();
            CaseStudy1(dynamicArray);
            CaseStudy2(resizedDynamicArray);
            CaseStudy3(dynamicArray,resizedDynamicArray);
        }

        private static void CaseStudy3(DynamicArray dynamicArray, DynamicArray resizedDynamicArray)
        {
         
        }

        private static void CaseStudy2( DynamicArray resizedDynamicArray)
        {
            int[] resizedArrayElement = resizedDynamicArray.GetArrayElement(10);
            Console.WriteLine("Array elemnts are");
            PrintArrayElement(resizedArrayElement);
        }

        private static void CaseStudy1(DynamicArray dynamicArray)
        {
            bool exitScreen = true;
            string res= "";
            while(exitScreen)
            {
                int[] arrayElement = dynamicArray.GetArrayElement(5);

                Console.WriteLine("Array elemnts are");
                PrintArrayElement(arrayElement);
                Console.WriteLine("Do you want to exit the screen or want to add more element to the array perss Y/N");
                res = Console.ReadLine();
                if (res == "Y")
                {
                    exitScreen = true;

                }
                else
                {
                    exitScreen = false;
                }
            }
           


        }

        private static void PrintArrayElement(int[] arrayElement)
        {
           foreach (int element in arrayElement)
            {
                Console.WriteLine(element);
            }
        }
    }
}
