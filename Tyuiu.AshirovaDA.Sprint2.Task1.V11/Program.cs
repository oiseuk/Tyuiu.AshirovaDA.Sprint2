using Tyuiu.AshirovaDA.Sprint2.Task1.V11.Lib;

// ЗАДАНИЕ
// Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении) и
// логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),
// а также арифметических выражений, которая вернет логическую последовательность(массив):
// (False, False, True, False, True, False), при a = 145, b = 156, c = 142, d = 117

namespace Tyuiu.AshirovaDA.Sprint2.Task1.V11

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Аширова Д. А. | РППб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Логические операции                                                *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #11                                                              *");
            Console.WriteLine("* Выполнила: Аширова Диана Артёмовна | РППб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=),         *");
            Console.WriteLine("* логических операций (|, &, ||, &&, !, ^) и арифметических выражений,     *");
            Console.WriteLine("* которая вернет логическую последовательность (массив):                   *");
            Console.WriteLine("* (False, False, True, False, True, False),                                *");
            Console.WriteLine("* при a = 145, b = 156, c = 142, d = 117                                   *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение d: ");
            int d = Convert.ToInt32(Console.ReadLine());

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine($"* a = {a}");
            Console.WriteLine($"* b = {b}");
            Console.WriteLine($"* c = {c}");
            Console.WriteLine($"* d = {d}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.Write("* (");

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i]);
                if (i < res.Length - 1)
                    Console.Write(", ");
            }

            Console.WriteLine(")");
            Console.WriteLine("***************************************************************************");
        }
    }
    }
