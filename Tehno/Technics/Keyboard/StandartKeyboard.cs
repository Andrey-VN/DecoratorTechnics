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
            GetName = "Стандартная клавиатура";
            GetCost = 1500;
        }
        public StandartKeyboard(ComputerTechnics computerTechnics)
        {
            this.computerTechnics = computerTechnics;
            GetName = "Стандартная клавиатура";
            GetCost = 1500;
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
