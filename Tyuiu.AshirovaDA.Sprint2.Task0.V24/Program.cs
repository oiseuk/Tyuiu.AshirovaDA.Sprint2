
using Tyuiu.AshirovaDA.Sprint2.Task0.V24.Lib;

namespace Tyuiu.AshirovaDA.Sprint2.Task0.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Аширова Д. А. | РППб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Операции сравнения                                                 *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #24                                                              *");
            Console.WriteLine("* Выполнила: Аширова Диана Артёмовна | РППб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,          *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических       *");
            Console.WriteLine("* выражений, которая вернет логическую последовательность (массив):        *");
            Console.WriteLine("* (True, True, False, False, True, True), при x = 135, y = 755             *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool[] result = ds.GetCompareOperations(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine($"* x = {x}");
            Console.WriteLine($"* y = {y}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine($"* ({result[0]}, {result[1]}, {result[2]}, {result[3]}, {result[4]}, {result[5]})");
            Console.WriteLine("***************************************************************************");
        }
    }
}