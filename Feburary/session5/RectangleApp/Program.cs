using RectangleApp.Model;
using System;
 

namespace RectangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle small; //explict object;
            Rectangle large;
            small= new Rectangle();
            large= new Rectangle();
            small.height=10;
            small.width=10;
            large.height=100;
            large.width=100;
            Console.WriteLine("The area of the small reactangle ,height:{0},widht:{1},area:{3}"+small.CalculateArea());
            Console.WriteLine("The area of the  large reactangle ,height:{0},width:{1},area:{3}"+large.CalculateArea());

        }
    }
}
