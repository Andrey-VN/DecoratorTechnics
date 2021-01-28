using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// В программе представлена реализация паттерна "Декоратор" на примере прокупки комплектующих компьютерной техники.
/// Каждая комплектующая в программе является и компонентом и декоратором, пользовотель сам выбирает компонент, к которому он может добавить дополнительные комплектующие.
/// С помощью программы можно высчитать полную сумму товаров и наименования комплектующих через "\", которые выбрал пользователь, а так же вывести характеристики компонентов по отдельности
/// </summary>
/// 
/// <summary>
/// Ниже в даннной дерективе представлен абстрактный класс, который определяет интерфейс для объектов, которые наследуются от него
/// </summary>
namespace Tehno.Technics
{

    public abstract class ComputerTechnics
    {
        protected string name;  //поле наименования товара

        protected double cost;  //поле суммы товара
        public abstract string GetName { get; protected set; } //абстрактное свойство имени товара 
        public abstract double GetCost { get; protected set; } //абстрактное свойство суммы товара 
    }
}
