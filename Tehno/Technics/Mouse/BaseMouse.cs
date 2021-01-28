using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehno.Technics.Mouse
{
    class BaseMouse : Mouse
    {
        public BaseMouse(ComputerTechnics computerTechnics)
        {
            this.computerTechnics = computerTechnics;
        }
        public override string GetName 
        {
            get { return name; }
            protected set { name = computerTechnics.GetName + " +Базовая мышь"; } 
        }
        public override double GetCost
        {
            get { return cost; }
            protected set { cost = computerTechnics.GetCost + 300; }
        }
    }
}
