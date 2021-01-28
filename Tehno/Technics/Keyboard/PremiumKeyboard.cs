using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehno.Technics.Keyboard
{
    class PremiumKeyboard : Keyboard
    {
        public PremiumKeyboard(ComputerTechnics computerTechnics)
        {
            this.computerTechnics = computerTechnics;
        }
        public override string GetName
        {
            get { return name; }
            protected set { name = computerTechnics.GetName + " +Премиальная клавиатура"; }
        }
        public override double GetCost
        {
            get { return cost; }
            protected set { cost = computerTechnics.GetCost + 3000; }
        }
    }
}
