using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehno.Technics.Keyboard
{
    class PremiumKeyboard : Keyboard
    {
        public PremiumKeyboard()
        {
            
        }
        public PremiumKeyboard(ComputerTechnics computerTechnics)
        {
            this.computerTechnics = computerTechnics;
        }
        public override string GetName
        {
            get { return name; }
            protected set 
            {
                if (computerTechnics.GetName == null)
                    name = "Премиальная клавиатура";
                else
                    name = computerTechnics.GetName + " +Премиальная клавиатура"; 
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
