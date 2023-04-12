using SimpleRectangleApp.Model;
using System;


namespace SimpleRectangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleA;
            rectangleA = new Rectangle();
            /*Console.WriteLine($"width is {rectangleA.width}"+
                $"and Height is {rectangleA.height}"+
                $"and color is {rectangleA.color} and arear is {rectangleA.CalculateArea()}");*/
            
            rectangleA.width = 10;
            rectangleA.height = 20;
            rectangleA.color = "blue";
            PrintDetails(rectangleA, "details of RectangleA");
            /*Console.WriteLine($"Rectangle A Details width is {rectangleA.width}" +
                $"and Height is {rectangleA.height}" +
                $"and color is {rectangleA.color} and arear is {rectangleA.CalculateArea()}");*/
            Rectangle rectangleB;
            rectangleB = rectangleA;
            /*Console.WriteLine($"Rectangle A Details width is {rectangleB.width}" +
               $"and Height is {rectangleB.height}" +
               $"and color is {rectangleB.color} and arear is {rectangleA.CalculateArea()}");*/
            PrintDetails(rectangleB, "details of RectangleB");
            rectangleB.color = "Yellow";
            Console.WriteLine($"color of rectangle B is :{rectangleB.color},hashcose is {rectangleB.GetHashCode()}");
            Console.WriteLine($"color of rectangle A is :{rectangleA.color},hashcose is {rectangleA.GetHashCode()}");

        }
        static void PrintDetails( Rectangle rectangle,string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"width is {rectangle.width}"+ $"height is {rectangle.height}"+$"color is {rectangle.color}");
        }
    }          

}
