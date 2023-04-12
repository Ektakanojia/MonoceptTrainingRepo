using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructApp
{
    internal class StructAndClass
    {
        public static void Main()
        {
            PointClass obj = new PointClass(10,20);
            Console.WriteLine("After the object of the class is created:");
            obj.ShowDetails();
            ModifyClassValue(obj);
            Console.WriteLine("After Modifyclassvalue Method invoked:");
            obj.ShowDetails();
            Console.WriteLine("..............");
            PointStruct objs= new PointStruct(100,200);
            Console.WriteLine("After the object of the struct is created:");
            objs.ShowDetails();
            ModifyStructValue(objs);
            Console.WriteLine("After Modfiystructvalue Method invoked");
            objs.ShowDetails();
        }

        private static void ModifyStructValue(PointStruct objs)
        {
            objs.no1 += 1000;
            objs.no2 += 1000;
            Console.WriteLine("Within the ModifyStructValue is :{0},{1}", objs.no1, objs.no2);
        }

        private static void ModifyClassValue(PointClass obj)
        {
            obj.no1 += 100;
            obj.no2 += 100;
            Console.WriteLine("Within the ModifyClassValue is :{0},{1}", obj.no1, obj.no2);
        }
    }
    //defining the class
    class PointClass
    {
        public int no1, no2;
        public PointClass(int n1,int n2) 
        {
            no1 = n1;
            no2 = n2;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Number1 :{0},Number 2:{1}", no1, no2);
        }
    }
    //defining the struct
    struct PointStruct
    {
        public int no1, no2;
        public PointStruct(int n1, int n2)
        {
            no1 = n1;
            no2 = n2;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Number1 :{0},Number 2:{1}", no1, no2);
        }
    }
}
