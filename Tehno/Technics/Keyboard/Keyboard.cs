using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///В данной дерективе реализуется декоратор в виде абстрактного класса семейства компьютерных клавиатур. В нем реализуется связь с базовым классом через наследование и отношением ассоциации, а в производных от него классах
///отношением агрегации к базовому классу ComputerTechnics. Каждый производный класс можно расширять другим производным классом от наследуемого абстрактного класса ComputerTechnics
/// </summary>
namespace Tehno.Technics.Keyboard
{
    abstract class Keyboard : ComputerTechnics
    {
        protected ComputerTechnics computerTechnics;
    }
}
