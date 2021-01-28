using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehno.Technics.Notebook
{
    class PremiumNotebook : Notebook
    {
        public PremiumNotebook()
        {

        }
        public PremiumNotebook(ComputerTechnics computerTechnics)
        {
            this.computerTechnics = computerTechnics;
        }
        public override string GetName
        {
            get { return name; }
            protected set
            {
                if (computerTechnics.GetName == null)
                    name = "Премиальный ноутбук";
                else
                    name = computerTechnics.GetName + " +Премиальный ноутбук";
            }
        }
        public override double GetCost
        {
            get { return cost; }
            protected set
            {
                if (computerTechnics.GetCost == default)
                    cost = 170000;
                else
                    cost = computerTechnics.GetCost + 170000;
            }
        }
    }
}
