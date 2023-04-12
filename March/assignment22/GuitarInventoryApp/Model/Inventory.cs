using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventoryApp.Model
{
    internal class Inventory
    {
        
        private readonly List<Guitar> _guitars;

        //constructor
        public Inventory() 
        { 
         //intialize the list
        _guitars= new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
        {
       
            Guitar guitar = new Guitar(serialNumber,price,builder,model,type,backWood,topWood);
            _guitars.Add(guitar);

        
        }
        
       
        
        
        

        
         


    }
}
