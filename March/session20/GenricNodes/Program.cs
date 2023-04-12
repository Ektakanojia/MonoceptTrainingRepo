using GenricNodes.Model;

namespace GenricNodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nodeA = new Node<int>();
            var nodeB = new Node<int>();
            var nodeC = new Node<int>();

            var nodeD = new Node<string>();
            var nodeE = new Node<string>();
            var nodeF = new Node<string>();
            nodeA.Data = 1;
            nodeB.Data = 2;
            nodeC.Data = 3;
            
            nodeD.Data = "Ekta";
            nodeE.Data = "Ankit";
            nodeF.Data = "Subran";


            nodeA.Next= nodeB;
            nodeB.Next= nodeC;
            //nodeC.Next=nodeD;
            nodeD.Next = nodeE;
            nodeE.Next= nodeF;
            PrintDetails(nodeA);
            //PrintDetails(nodeD);
        }

        private static void PrintDetails<T>(Node<T> nodeA)
        {
         while(nodeA != null)
            {
                Console.WriteLine(nodeA.Data);
                nodeA = nodeA.Next;
            }  
        }
    }
}