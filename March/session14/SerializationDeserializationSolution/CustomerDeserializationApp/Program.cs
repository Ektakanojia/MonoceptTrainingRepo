using CustomerLib.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace CustomerDeserializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("Customer1.dump",FileMode.Open,FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Object obj=binaryFormatter.Deserialize(fs);
            Customer c=obj as Customer;
            Console.WriteLine(c.Name);
            Console.WriteLine(c.Id);
            fs.Close();
             
            
           
        }
    }
}
