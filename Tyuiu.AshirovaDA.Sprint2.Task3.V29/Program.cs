using Tyuiu.AshirovaDA.Sprint2.Task3.V29.Lib;
// ЗАДАНИЕ 
//Написать программу, которая вычисляет требуемое значение функции Y с использованием вложенных оператор if-else,
//где пользователь вводит значение переменной X с клавиатуры. Округлить полученное значение до трех знаков после запятой;
namespace Tyuiu.AshirovaDA.Sprint2.Task3.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Аширова Д. А. | РППб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Вложенные операторы if — else                                      *");
            Console.WriteLine("* Задание #2.3                                                             *");
            Console.WriteLine("* Вариант #29                                                              *");
            Console.WriteLine("* Выполнила: Аширова Диана Артёмовна | РППб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y       *");
            Console.WriteLine("* с использованием вложенных операторов if-else, где пользователь          *");
            Console.WriteLine("* вводит значение переменной X с клавиатуры.                               *");
            Console.WriteLine("* Округлить полученное значение до трёх знаков после запятой.              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine($"* X = {x}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine($"* Y = {result}");
            Console.WriteLine("***************************************************************************");
        }
    }
}
