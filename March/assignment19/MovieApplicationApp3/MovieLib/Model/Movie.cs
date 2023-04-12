using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBusinessLayerLibrary.Model
{
    [Serializable]
   

    public class Movie
    {

        private string _name;
        private int _year;

        public Movie() { }
       public int Year { get; set; }
       public string Name { get; set; }
       
        
    }
}
