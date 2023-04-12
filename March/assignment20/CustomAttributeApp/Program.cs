using CustomAttributeApp.Model;

namespace CustomAttributeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NeedToRefactor.DisplayNeedToRefactorAttribute(typeof(Foo));
            Console.WriteLine();
            NeedToRefactor.DisplayNeedToRefactorAttribute(typeof(Bar));

        }
    }
}