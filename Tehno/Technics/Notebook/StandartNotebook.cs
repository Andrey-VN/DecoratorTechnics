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
            GetName = "Стандартный ноутбук";
            GetCost = 60000;
        }
        public StandartNotebook(ComputerTechnics computerTechnics)
        {
            this.computerTechnics = computerTechnics;
            GetName = "Стандартный ноутбук";
            GetCost = 60000;
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

