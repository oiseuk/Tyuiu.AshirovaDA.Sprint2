using tyuiu.cources.programming.interfaces.Sprint2;

    // ЗАДАНИЕ
    //Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)
    //и арифметических выражений,которая вернет логическую последовательность(массив):
    //(True, True, False, False, True, True), при x = 135, y = 755

namespace Tyuiu.AshirovaDA.Sprint2.Task0.V24.Lib
{
    public class DataService : ISprint2Task0V24
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + y == y + x;       // True  (всегда True)
            res[1] = x * 2 != y * 2;       // True  (135·2=270 ≠ 755·2=1510)
            res[2] = x * y < y * x;        // False (равны, не меньше)
            res[3] = x + y > y * 2;        // False (890 > 1510 → False)
            res[4] = x + x <= y;           // True  (270 ≤ 755)
            res[5] = y + y >= x * 2;       // True  (1510 ≥ 270)

            return res;
        }
    }
}
