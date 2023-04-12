namespace MathsDelegateApp
{
    internal class Program
    {
        delegate void DMathsOpertion(int n1,int n2);
        static void Main(string[] args)
        {
            DMathsOpertion obj = Add;
            obj += Substract;
            obj+= Divide;
            obj += Multiply;
            obj(10, 20);

        }

        static void Add(int n1,int n2)
        {
            Console.WriteLine("ADD:"+ (n1+n2));
        }
        static void Substract(int n1,int n2)
        {
            Console.WriteLine("SUBTRACT :"+(n2-n1));
        }

        static void Multiply(int n1,int n2)
        {
            Console.WriteLine("Multiply :"+(n1*n2));
        }
         static void Divide(int n1,int n2)
        {
            Console.WriteLine("Divide :"+(n2/n1));
        }
    }
}