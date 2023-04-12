using CircleApp.Model;
using System;

namespace CircleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle smallCircle=new Circle();
            smallCircle.SetRadius(10);
            smallCircle.SetBorderStyle("");
            smallCircle.SetColor("GREEN");
            PrintCircleDetails(smallCircle, "Details of the small circle");
            Circle bigCircle = new Circle();
            bigCircle.SetRadius(50);
            bigCircle.SetBorderStyle("dottedline");
            bigCircle.SetColor("YELLOW");
            PrintCircleDetails(bigCircle, "Details of the big circle");

        }
       static void PrintCircleDetails(Circle circle, string title)
        {
            Console.WriteLine(title.ToUpper());
            Console.WriteLine($"radius is :{circle.GetRadius()}");
            Console.WriteLine($"border style is :{circle.GetBorderStyle()}");
            Console.WriteLine($"color is: {circle.GetColor()}");
        }
    }
}
