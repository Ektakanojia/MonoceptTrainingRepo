using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationAppOop.Model
{
    internal class DataConnection
    {
        private string _server;
        private string _database;

        // constructor
        public DataConnection(string connection)
        {
             _database=connection;
            _server = connection;

        }

    }
}
