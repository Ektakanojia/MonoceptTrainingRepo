using MoveableInterfaceApp.Model;

namespace ImoveableRefactoredApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMoveable[] moveables =
            {
                new Car("Honda"),
                new Bike("BMW"),

            };
            StartRace(moveables);
        }

        static void StartRace(IMoveable[] moveables)
        {
            Console.WriteLine("Race started");
            foreach(IMoveable moveable in moveables)
            {
                moveable.Move();
            }
        }
    }
}