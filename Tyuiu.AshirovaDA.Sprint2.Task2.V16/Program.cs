
using Tyuiu.AshirovaDA.Sprint2.Task2.V16.Lib;

namespace Tyuiu.AshirovaDA.Sprint2.Task2.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Аширова Д. А. | РППб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Оператор if — полная и короткая форма записи                       *");
            Console.WriteLine("* Вариант #16                                                              *");
            Console.WriteLine("* Выполнила: Аширова Диана Артёмовна | РППб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры      *");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X, Y в заштрихованной     *");
            Console.WriteLine("* области (буква «Ч» на сетке 15×15).                                      *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine($"* X = {x}");
            Console.WriteLine($"* Y = {y}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine($"* Точка в заштрихованной области: {result}");
            Console.WriteLine("***************************************************************************");
        }
    }
}