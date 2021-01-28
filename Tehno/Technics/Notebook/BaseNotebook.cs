using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehno.Technics.Notebook
{
    class BaseNotebook : Notebook
    {
        public BaseNotebook(ComputerTechnics computerTechnics)
        {
            this.computerTechnics = computerTechnics;
        }
        public override string GetName
        {
            get { return name; }
            protected set { name = computerTechnics.GetName + " +Базовый нотбук"; }
        }
        public override double GetCost
        {
            get { return cost; }
            protected set { cost = computerTechnics.GetCost + 30000; }
        }
    }
}
