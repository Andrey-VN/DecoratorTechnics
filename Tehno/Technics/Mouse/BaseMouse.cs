using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehno.Technics.Mouse
{
    class BaseMouse : Mouse
    {
        public override string GetName { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public override double GetCost { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
    }
}
