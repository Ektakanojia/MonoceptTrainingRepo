using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdRefactored.Model
{
    internal interface IBirdCanFly
    {
        public string Name { get; set; }
        bool CanFly();
    }
}
