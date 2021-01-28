using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehno.Technics.Keyboard
{
    class BaseKeyboard : Keyboard
    {
        public BaseKeyboard()
        {
            
        }
        public BaseKeyboard(ComputerTechnics computerTechnics)
        {
            this.computerTechnics = computerTechnics;
        }
        public override string GetName
        {
            get { return name; }
            protected set 
            { 
                if(computerTechnics.GetName == null)
                    name = "Базовая клавиатура";
                else
                name = computerTechnics.GetName + " +Базовая клавиатура"; 
            }
        }
        public override double GetCost
        {
            get { return cost; }
            protected set
            {
                if (computerTechnics.GetCost == default)
                    cost = 500;
                else
                    cost = computerTechnics.GetCost + 500;
            }
        }
    }
}
