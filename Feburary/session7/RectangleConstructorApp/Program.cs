using RectangleApp.Model;
using System;


namespace RectangleConstructorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails(new Rectangle(width: 100, height: 50, color: "red"),"Details of rectangle");
            Rectangle rectangleA = new Rectangle(100, 20, "green");
            rectangleA.SetColor("red");
            PrintDetails(rectangleA, "Rectangle A after color change");
        }
        static void PrintDetails(Rectangle rectangle, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("width is :"+ rectangle.GetWidth());
            Console.WriteLine("height is:" + rectangle.GetHeight());
            Console.WriteLine("color is :" + rectangle.GetColor());
        }
    }
}
