using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehno.Technics.Notebook
{
    class StandartNotebook : Notebook
    {
        public StandartNotebook(ComputerTechnics computerTechnics)
        {
            this.computerTechnics = computerTechnics;
        }
        public override string GetName
        {
            get { return name; }
            protected set { name = computerTechnics.GetName + " +Стандартный нотбук"; }
        }
        public override double GetCost
        {
            get { return cost; }
            protected set { cost = computerTechnics.GetCost + 60000; }
        }
    }
}

