using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterface.Model
{
    internal interface ICurdable
    {
        void Create();
        
        void Read();

        void Update();
        void Delete();
    }
}
