using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
///В данной дерективе представлена конкретная реализация дополнительной функциональности для объектов. Сам объект может представлять сам компонент, к которому добавляется новая функциональность
///
/// Если идет вызов конструктора по умолчанию, то объект будет явлеться компонентом, к которому можно будет добавить новую функциональность. 
/// Если идет вызов пользовотельского конструктора, то обкт будет явлеться декоратором для объекта, который будет использоваться в виде аргумента
/// </summary>

namespace Tehno.Technics.Notebook
{
    class BaseNotebook : Notebook
    {
        public BaseNotebook()
        {
            GetName = "Базовый ноутбук";
            GetCost = 30000;
        }
        public BaseNotebook(ComputerTechnics computerTechnics)     //связь данного класса с классом ComputerTechnics отношением агрегации. Дает возможность добавлять 
                                                                   // в конструктор новую функциональность для текущего объекта
        {
            this.computerTechnics = computerTechnics;
            GetName = "Базовый ноутбук";
            GetCost = 30000;
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
