using System;
using Tyuiu.AshirovaDA.Sprint2.Task6.V8.Lib;

namespace Tyuiu.AshirovaDA.Sprint2.Task6.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Аширова Д.А. | ...";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Аширова Д.А.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая по заданной дате (день и месяц) находит     *");
            Console.WriteLine("* дату предыдущего дня.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите число n (день, 1-31): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер месяца m (1-12): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine($"* Дата = {n:D2}.{m:D2}                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.FindDateOfPreviousDay(n, m);
            Console.WriteLine($"* Предыдущий день = {res}                                             *");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}