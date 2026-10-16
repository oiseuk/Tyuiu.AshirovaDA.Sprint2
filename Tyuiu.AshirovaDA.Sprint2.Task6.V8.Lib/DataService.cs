using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AshirovaDA.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int n, int m)
        {
            // n — день, m — месяц

            if (n > 1)
            {
                n--;   // уменьшаем день
            }
            else
            {
                // n == 1 → переходим на последний день предыдущего месяца
                int daysInPrevMonth = m switch
                {
                    2 => 31,   // предыдущий для февраля — январь
                    3 => 28,   // предыдущий для марта — февраль (не високосный)
                    4 => 31,
                    5 => 30,
                    6 => 31,
                    7 => 30,
                    8 => 31,
                    9 => 31,
                    10 => 30,
                    11 => 31,
                    12 => 30,
                    _ => throw new ArgumentException($"Неверный номер месяца: {m}")
                };

                n = daysInPrevMonth;
                m--;
            }

            return $"{n:D2}.{m:D2}";   // ДД.ММ
        }
    }
}