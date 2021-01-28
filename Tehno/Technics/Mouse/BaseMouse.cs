using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehno.Technics.Mouse
{
    class BaseMouse : Mouse
    {
        public BaseMouse()
        {
            
        }
        public BaseMouse(ComputerTechnics computerTechnics)
        {
            this.computerTechnics = computerTechnics;
        }
        public override string GetName 
        {
            get { return name; }
            protected set
            {
                if (computerTechnics.GetName == null)
                    name = "Базовая мышь";
                else
                    name = computerTechnics.GetName + " +Базовая мышь";
            }
        }
        public override double GetCost
        {
            get { return cost; }
            protected set
            {
                if (computerTechnics.GetCost == default)
                    cost = 300;
                else
                    cost = computerTechnics.GetCost + 300;
            }
        }
    }
}
