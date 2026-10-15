using Tyuiu.AshirovaDA.Sprint2.Task5.V11.Lib;

namespace Tyuiu.AshirovaDA.Sprint2.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Аширова Д. А. | РППб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Оператор switch                                                    *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #11                                                              *");
            Console.WriteLine("* Выполнила: Аширова Диана Артёмовна | РППб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:          *");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число).                        *");
            Console.WriteLine("* По заданным g, n и m определить дату следующего дня.                     *");
            Console.WriteLine("* Заданный год не является високосным.                                     *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите год g: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите месяц m (1-12): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите день n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string result = ds.FindDateOfNextDay(g, m, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine($"* Дата = {n:D2}.{m:D2}.{g}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine($"* Следующий день = {result}");
            Console.WriteLine("***************************************************************************");
        }
    }
}