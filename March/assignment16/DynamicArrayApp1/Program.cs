using System;
using System.Runtime.InteropServices;

namespace DynamicArrayApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //case study1 it take array of fixed size and ask user to enter the element and press Y/N for exit the screen if N then it will display all the elements of array
            CaseStudy1();
            //CaseStudy2();
            
        }

      

        
        private static void CaseStudy2()
        {
            //string res;
            //bool exitScreen = true;
            int[] dynamicArray = new int[5];
            string num = "0123456789";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the array element");
                num = Console.ReadLine();
                if (isNumber(num))
                {
                    int ele = int.Parse(num);
                    dynamicArray[i] = ele;
                }
                else if(isNotNumber(num)) 
                {
                    displayArrayElement(dynamicArray);
                }
            }
            displayArrayElement(dynamicArray);
        }

        private static bool isNotNumber(string num)
        {
            Console.WriteLine("please enter the number only");
            return false;
        }

        private static bool isNumber(string num)
        {
            bool exitScreen = true;
            string res = "";
            for (int i = 0; i < num.Length; i++)
                if (char.IsDigit(num[i]) == false)
                {
                    ExitScreen(out exitScreen, out res);
                }
                    

            return true;
        }

        private static void CaseStudy1()
        {
            bool exitScreen = true;
            int[] dynamicArray = new int[5];
            string num;
            string res;
            while (exitScreen)
            {

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Enter the array element");
                    num = Console.ReadLine();
                    int ele = int.Parse(num);
                    dynamicArray[i] = ele;
                }
                ExitScreen(out exitScreen, out res);
            }
            displayArrayElement(dynamicArray);

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
                exitScreen = false;
        }

        private static void displayArrayElement(int[] dynamicArray)
        {
            // throw new NotImplementedException();
            Console.WriteLine("Array element is ");
            foreach (int ele in dynamicArray)
            {
                Console.WriteLine(ele);
            }
        }
    }
}