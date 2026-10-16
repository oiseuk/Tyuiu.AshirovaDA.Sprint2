using System;
using Tyuiu.AshirovaDA.Sprint2.Task6.V8.Lib;

namespace Tyuiu.AshirovaDA.Sprint2.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Аширова Д. А. | РППб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Сокращённая форма записи оператора switch                          *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #8                                                               *");
            Console.WriteLine("* Выполнила: Аширова Диана Артёмовна | РППб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:          *");
            Console.WriteLine("* n (порядковый номер месяца) и m (число).                                 *");
            Console.WriteLine("* По заданным n и m определить дату предыдущего дня                        *");
            Console.WriteLine("* (принять, что n и m не характеризуют 1 января).                          *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер месяца n (2-12): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            string result = ds.FindDateOfPreviousDay(n, m);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine($"* Дата = {m:D2}.{n:D2}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine($"* Предыдущий день = {result}");
            Console.WriteLine("***************************************************************************");
        }
    }
}