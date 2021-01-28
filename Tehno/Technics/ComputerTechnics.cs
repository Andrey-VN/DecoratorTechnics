using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehno.Technics
{
    public abstract class ComputerTechnics
    {
        public abstract string GetName { get; protected set; }
        public abstract double GetCost { get; protected set; }
    }
}
