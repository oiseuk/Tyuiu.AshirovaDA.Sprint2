using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AshirovaDA.Sprint2.Task3.V29.Lib
{
    public class DataService : ISprint2Task3V29
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                // x * ((x+1)/(x-1))^5
                y = x * Math.Pow((x + 1) / (x - 1), 5);
            }
            else if (x == 0)
            {
                // (x² - cos(x²) + 6) / (x² - sin(x²) + 5)
                double numerator = x * x - Math.Cos(x * x) + 6;
                double denominator = x * x - Math.Sin(x * x) + 5;
                y = numerator / denominator;
            }
            else if (x > -33 && x < 2)
            {
                // (1 + 1/x²)^x
                y = Math.Pow(1 + 1 / (x * x), x);
            }
            else // x < -33
            {
                // x + 10x - 1/x
                y = x + 10 * x - 1 / x;
            }

            return Math.Round(y, 3, MidpointRounding.AwayFromZero);
        }
    }
}