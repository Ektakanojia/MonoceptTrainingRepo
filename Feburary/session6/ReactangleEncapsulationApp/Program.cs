using RectangleApp.Model;

using System;


namespace ReactangleEncapsulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangleA = new Rectangle();
            rectangleA.SetWidth(101);
            rectangleA.SetHeight(-100);
            rectangleA.SetColor("abcd");
            PrintDetails(rectangleA, "Details of rectangle A");
            Rectangle rectangleB=new Rectangle();
            rectangleB.SetWidth(20);
            rectangleB.SetHeight(30);
            rectangleB.SetColor("BLUE");
            PrintDetails(rectangleB, "Details of rectangle B");


        }
        static void PrintDetails(Rectangle rectangle,string des)
        {
            Console.WriteLine(des.ToUpper());
            Console.WriteLine($"width is {rectangle.GetWidth()}");
            Console.WriteLine($"height is {rectangle.GetHeight()}");
            Console.WriteLine($"color is {rectangle.GetColor()}");
        }
    }
}
