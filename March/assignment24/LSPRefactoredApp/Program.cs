using LSPVoliationApp.Model;

namespace LSPRefactoredApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ItShouldNotChangeHeight_IfWidthIsModifiyed(new Rectangle(100,200));
           //ItShouldNotChangeHeight_IfWidthIsModifiyed(new Square(80));
        }

        private static void ItShouldNotChangeHeight_IfWidthIsModifiyed(Rectangle rectangle)
        {
            int beforeChange = rectangle.GetHeight();
            rectangle.SetWidth(rectangle.GetWidth() + 10);
            int afterChange = rectangle.GetHeight();
            Console.WriteLine(beforeChange == afterChange);
            Console.WriteLine(beforeChange);
            Console.WriteLine(afterChange);
        }
    }
}