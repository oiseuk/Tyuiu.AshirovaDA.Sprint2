using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AshirovaDA.Sprint2.Task4.V17.Lib
{
    public class DataService : ISprint2Task4V17


    {
        public double Calculate(double x, double y)
        {
            double z = x - 22 > Math.Sqrt(y)
               ? Math.Pow(6 + 2 / (x * x), y)     // если условие True
               : y + 12 / (x * x);                 // иначе

            return Math.Round(z, 3, MidpointRounding.AwayFromZero);
        }
    }
}
