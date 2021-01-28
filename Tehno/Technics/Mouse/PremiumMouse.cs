using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehno.Technics.Mouse
{
    class PremiumMouse : Mouse
    {
        public PremiumMouse()
        {

        }
        public PremiumMouse(ComputerTechnics computerTechnics)
        {
            this.computerTechnics = computerTechnics;
        }
        public override string GetName
        {
            get { return name; }
            protected set
            {
                if (computerTechnics.GetName == null)
                    name = "Премиальная мышь";
                else
                    name = computerTechnics.GetName + " +Премиальная мышь";
            }
        }
        public override double GetCost
        {
            get { return cost; }
            protected set
            {
                if (computerTechnics.GetCost == default)
                    cost = 1200;
                else
                    cost = computerTechnics.GetCost + 1200;
            }
        }
    }
}
