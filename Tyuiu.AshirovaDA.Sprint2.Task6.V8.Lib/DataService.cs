using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AshirovaDA.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int n, int m)
        {
            // Если m > 1 → просто m - 1
            if (m > 1)
            {
                m--;
            }
            else
            {
                // m == 1 → переходим на последний день предыдущего месяца
                // Через сокращённую форму switch получаем дней в предыдущем месяце
                int daysInPrevMonth = n switch
                {
                    2 => 31,   // предыдущий для февраля — январь (31)
                    3 => 28,   // предыдущий для марта — февраль (28, не високосный)
                    4 => 31,
                    5 => 30,
                    6 => 31,
                    7 => 30,
                    8 => 31,
                    9 => 31,
                    10 => 30,
                    11 => 31,
                    12 => 30,
                    _ => throw new ArgumentException($"Неверный номер месяца: {n}")
                };

                m = daysInPrevMonth;
                n--;
            }

            return $"{m:D2}.{n:D2}";
        }
    }
}