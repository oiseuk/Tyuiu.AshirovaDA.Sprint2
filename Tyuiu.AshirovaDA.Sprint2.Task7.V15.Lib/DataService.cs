using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AshirovaDA.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            // Заштрихованная область — полукольцо в верхней полуплоскости:
            //   y >= 0  И  1 <= x^2 + y^2 <= 4
            if (y >= 0 && (x * x + y * y) >= 1 && (x * x + y * y) <= 4)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}