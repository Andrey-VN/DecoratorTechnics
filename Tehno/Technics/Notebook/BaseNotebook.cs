using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehno.Technics.Notebook
{
    class BaseNotebook : Notebook
    {
        public BaseNotebook()
        {

        }
        public BaseNotebook(ComputerTechnics computerTechnics)
        {
            this.computerTechnics = computerTechnics;
        }
        public override string GetName
        {
            get { return name; }
            protected set
            {
                if (computerTechnics.GetName == null)
                    name = "Базовый ноутбук";
                else
                    name = computerTechnics.GetName + " +Базовый ноутбук";
            }
        }
        public override double GetCost
        {
            get { return cost; }
            protected set
            {
                if (computerTechnics.GetCost == default)
                    cost = 3000;
                else
                    cost = computerTechnics.GetCost + 3000;
            }
        }
    }
}
