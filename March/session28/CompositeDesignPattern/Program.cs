using CompositeDesignPattern.Model;

namespace CompositeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Folder compositeRoot = new Folder("Movies");
            compositeRoot.AddChild(new File("A.avi",700));
            compositeRoot.AddChild(new File("B.avi", 400));

            Folder action = new Folder("Action");
            compositeRoot.AddChild(action);
            action.AddChild(new File("D.avi", 300));
            compositeRoot.Display();
        }
    }
}