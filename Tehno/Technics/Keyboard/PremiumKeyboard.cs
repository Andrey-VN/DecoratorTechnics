﻿using System;
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
            GetName = "Премиальная клавиатура";
            GetCost = 3000;
        }
        public PremiumKeyboard(ComputerTechnics computerTechnics) 
        {
            this.computerTechnics = computerTechnics;
            GetName = "Премиальная клавиатура";
            GetCost = 3000;

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
