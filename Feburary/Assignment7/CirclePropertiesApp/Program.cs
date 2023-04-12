using CirclePropertiesApp.Model;
using System;


namespace CirclePropertiesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10,"dottedline","red");
            PrintDetails(circle, "Details of circle");
            circle.Color = "blue";
            circle.BorderStyle = "doubleline";
            PrintDetails(circle, "Details of circle after changing the color and Borderstyle");


        }
        static void PrintDetails(Circle circle, string title)
        {
            Console.WriteLine(title.ToUpper());
            Console.WriteLine("radius of the circle :" + circle.Radius);
            Console.WriteLine("Border style of the circle :" + circle.BorderStyle);
            Console.WriteLine("color of the circle is :" + circle.Color);
        }

    }
}
