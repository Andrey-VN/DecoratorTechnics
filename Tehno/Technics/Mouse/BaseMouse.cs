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
            GetName = "Базовая мышь";
            GetCost = 300;
        }
        public BaseMouse(ComputerTechnics computerTechnics)
        {
            
            this.computerTechnics = computerTechnics;
            GetName = "Базовая мышь";
            GetCost = 300;
        }
        public override string GetName
        {
            get { return name; }
            protected set
            {
                if (computerTechnics == default)
                    name = value;
                else
                    name = computerTechnics.GetName + "/" + value;
            }
        }
        public override double GetCost
        {
            get { return cost; }
            protected set
            {
                if (computerTechnics == default)
                    cost = value;
                else
                    cost = computerTechnics.GetCost + value;
            }
        }
    }
}
