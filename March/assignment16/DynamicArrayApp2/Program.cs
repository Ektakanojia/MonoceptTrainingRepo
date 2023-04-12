using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitScreen = true;
            string res;
            int size = 5;
            int[] dynamicArray = new int[size];
            int[] dynamicArray2 = new int[size * 2];
            string num;
            int ele;
            while (exitScreen)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Enter the array element");
                    num = Console.ReadLine();
                    ele = int.Parse(num);
                    dynamicArray[i] = ele;
                }
               
                Console.WriteLine("Enter Y/N for exit the screen");
                res = Console.ReadLine();
                if (res == "Y")
                {
                    exitScreen = true;
                    Console.WriteLine("resized array");
                    dynamicArray2 = DoubleTheSizeOfArray(size, dynamicArray, dynamicArray2);
                }

                else
                {
                    exitScreen = false;


                }
                Console.WriteLine("array element is:");
                PrintArrayElement(dynamicArray);
                Console.WriteLine("resized array");
                dynamicArray2 = DoubleTheSizeOfArray(size, dynamicArray, dynamicArray2);
            }

        }

        private static int[] DoubleTheSizeOfArray(int size, int[] dynamicArray, int[] dynamicArray2)
        {
            CopyElement(dynamicArray, dynamicArray2, 0);
            ResizedArray(dynamicArray2);
            Console.WriteLine("array after resize");
            PrintArrayElement(dynamicArray2);
            return dynamicArray2;
        }

        private static void CopyElement(int[] dynamicArray, int[] dynamicArray2, int v)
        {
            int size = dynamicArray2.Length;
            for (int i = 0; i < size / 2; i++)
            {
                dynamicArray2[i] = dynamicArray[i];
            }
        }

        private static void ResizedArray(int[] dynamicArray2)
        {
            bool exitScreen = true;
            string res;
            int size = dynamicArray2.Length;
            string num;
            int ele;


            for (int i = size / 2; i < size; i++)
            {
                num = Console.ReadLine();
                ele = int.Parse(num);
                dynamicArray2[i] = ele;

            }


            PrintArrayElement(dynamicArray2);
            ExitScreen(out exitScreen, out res);

        }

        private static void ExitScreen(out bool exitScreen, out string res)
        {
            Console.WriteLine("Enter Y/N for exit the screen");
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

        private static void PrintArrayElement(int[] dynamicArray)
        {
            Console.WriteLine("Array element are :");
            foreach (int i in dynamicArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
