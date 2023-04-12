using System;

namespace BasicStatsApp
{
    internal class Program
    {
        static void Main(string[] argsOfValues)
        {
            int sum = 0; int count=0; int max = 0;int avg=0;
            int[] intArray = Array.ConvertAll(argsOfValues, s => int.Parse(s));
            for(int i = 0; i < intArray.Length; i++)
            {
                sum += intArray[i];
                count++;
                if (intArray[i] > max)
                {
                    max = intArray[i];
                }
                avg=sum/count;
            }
            Console.WriteLine("The sum of the array element is :" + sum);
            Console.WriteLine("The count of the array element is :" + count);
            Console.WriteLine("The maximum element of the array is :" + max);
            Console.WriteLine("The average of the array element is :" + avg);
        }
    }
}
