using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tehno.Technics;
using Tehno.Technics.Mouse;
using Tehno.Technics.Keyboard;
using Tehno.Technics.Notebook;


/// </summary>
/// Демонстрация работы программы на примере двух заказов, в которых идет вызов свойств с общим перечнем товаров и их стоимости
/// Во втором заказе дополнительно выведена информация о каждой комплектующей - стоимость и наименование
/// </summary>
namespace Tehno
{
    class Program
    {
        static void Main(string[] args)
        {
         

            ComputerTechnics order_1 = new PremiumKeyboard(new BaseMouse(new BaseNotebook()));
            Console.WriteLine("Заказ №1");
            Console.WriteLine("Перечень всех комплектующих заказа №1: {0}",order_1.GetName);
            Console.WriteLine("Общая стоимость комплектующих заказа №1: {0}", order_1.GetCost);

            Console.WriteLine();

            ComputerTechnics order_2 = new PremiumKeyboard(new BaseMouse(new BaseNotebook(new PremiumMouse(new StandartKeyboard()))));
            Console.WriteLine("Заказ №2");
            Console.WriteLine("Перечень всех комплектующих заказа №2: {0}", order_2.GetName);
            Console.WriteLine("Общая стоимость комплектующих заказа №2: {0}", order_2.GetCost);
            Console.WriteLine();
            Console.WriteLine("Стоимость товара \"{0}\" из заказа №2 составляет: {1}", new StandartKeyboard().GetName, new StandartKeyboard().GetCost);  //вызовы методов по слабой ссылке
            Console.WriteLine("Стоимость товара \"{0}\" из заказа №2 составляет: {1}", new PremiumMouse().GetName, new PremiumMouse().GetCost);
            Console.WriteLine("Стоимость товара \"{0}\" из заказа №2 составляет: {1}", new BaseNotebook().GetName, new BaseNotebook().GetCost);
            Console.WriteLine("Стоимость товара \"{0}\" из заказа №2 составляет: {1}", new BaseMouse().GetName, new BaseMouse().GetCost);
            Console.WriteLine("Стоимость товара \"{0}\" из заказа №2 составляет: {1}", new PremiumKeyboard().GetName, new PremiumKeyboard().GetCost);


            Console.Read();
        }
    }
}
