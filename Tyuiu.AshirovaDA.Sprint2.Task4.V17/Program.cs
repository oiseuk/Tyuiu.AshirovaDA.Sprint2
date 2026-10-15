using Tyuiu.AshirovaDA.Sprint2.Task4.V17.Lib;

namespace Tyuiu.AshirovaDA.Sprint2.Task4.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Аширова Д. А. | РППб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Тернарный оператор                                                 *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #17                                                              *");
            Console.WriteLine("* Выполнила: Аширова Диана Артёмовна | РППб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с               *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит             *");
            Console.WriteLine("* значения переменных x, y с клавиатуры:                                   *");
            Console.WriteLine("* если x - 22 > √y, то z = (6 + 2/x²)^y, иначе y + 12/x²                   *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                               *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine($"* x = {x}");
            Console.WriteLine($"* y = {y}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine($"* z = {result}");
            Console.WriteLine("***************************************************************************");
        }
    }
}