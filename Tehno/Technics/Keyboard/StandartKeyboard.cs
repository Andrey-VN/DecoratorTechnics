using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehno.Technics.Keyboard
{
    class StandartKeyboard : Keyboard
    {
        public StandartKeyboard()
        {

        }
        public StandartKeyboard(ComputerTechnics computerTechnics)
        {
            this.computerTechnics = computerTechnics;
        }
        public override string GetName
        {
            get { return name; }
            protected set
            {
                if (computerTechnics.GetName == null)
                    name = "Стандартная клавиатура";
                else
                    name = computerTechnics.GetName + " +Стандартная клавиатура";
            }
        }
        public override double GetCost
        {
            get { return cost; }
            protected set
            {
                if (computerTechnics.GetCost == default)
                    cost = 1500;
                else
                    cost = computerTechnics.GetCost + 1500;
            }
        }
    }
}
