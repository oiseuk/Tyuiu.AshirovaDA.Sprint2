using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AshirovaDA.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth = 0;   // ← инициализация обязательна

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    daysInMonth = 28;
                    break;
                default:
                    return "Неверный месяц";
            }

            if (n == daysInMonth)
            {
                n = 1;
                m++;
                if (m > 12)
                {
                    m = 1;
                    g++;
                }
            }
            else
            {
                n++;
            }

            return $"{n:D2}.{m:D2}.{g}";
        }
    }
}