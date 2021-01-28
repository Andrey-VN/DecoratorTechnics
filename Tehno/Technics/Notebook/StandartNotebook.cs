using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehno.Technics.Notebook
{
    class StandartNotebook : Notebook
    {
        public StandartNotebook()
        {

        }
        public StandartNotebook(ComputerTechnics computerTechnics)
        {
            this.computerTechnics = computerTechnics;
        }
        public override string GetName
        {
            get { return name; }
            protected set
            {
                if (computerTechnics.GetName == null)
                    name = "Стандартный ноутбук";
                else
                    name = computerTechnics.GetName + " +Стандартный ноутбук";
            }
        }
        public override double GetCost
        {
            get { return cost; }
            protected set
            {
                if (computerTechnics.GetCost == default)
                    cost = 60000;
                else
                    cost = computerTechnics.GetCost + 60000;
            }
        }
    }
}

