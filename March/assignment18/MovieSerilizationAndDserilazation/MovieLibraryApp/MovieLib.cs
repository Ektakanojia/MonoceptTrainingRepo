using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibraryApp
{
    [Serializable]
    public class MovieLib
    {
        private string _movieName;
        private int _movieYear;

        public MovieLib(string movieName,int movieYear)
        {
            _movieName= movieName;
            _movieYear= movieYear;
        }
        public string MovieName
        {
            get { return _movieName; }
            set { _movieName = value; }
        }
        public int MovieYear
        {
            get { return _movieYear; }
            set { _movieYear = value; }
        }
    }
}
