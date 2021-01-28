using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehno.Technics.Mouse
{
    class StandartMouse : Mouse
    {
        public StandartMouse()
        {

        }
        public StandartMouse(ComputerTechnics computerTechnics)
        {
            this.computerTechnics = computerTechnics;
        }
        public override string GetName
        {
            get { return name; }
            protected set
            {
                if (computerTechnics.GetName == null)
                    name = "Стандартная мышь";
                else
                    name = computerTechnics.GetName + " +Стандартная мышь";
            }
        }
        public override double GetCost
        {
            get { return cost; }
            protected set
            {
                if (computerTechnics.GetCost == default)
                    cost = 600;
                else
                    cost = computerTechnics.GetCost + 600;
            }
        }
    }
}
