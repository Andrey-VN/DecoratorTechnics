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
            GetName = "Премиальный ноутбук";
            GetCost = 170000;
        }
        public PremiumNotebook(ComputerTechnics computerTechnics)
        {
            this.computerTechnics = computerTechnics;
            GetName = "Премиальный ноутбук";
            GetCost = 170000;
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
