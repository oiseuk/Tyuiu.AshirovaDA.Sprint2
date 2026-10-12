using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AshirovaDA.Sprint2.Task2.V16.Lib
{
    public class DataService : ISprint2Task2V16
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // Левая вертикальная полоса (буква Ч)
            if (x >= 3 && x <= 5 && y >= 3 && y <= 12) return true;

            // Правая вертикальная полоса
            if (x >= 13 && x <= 15 && y >= 3 && y <= 12) return true;

            // Левая перекладина (сверху)
            if (x >= 6 && x <= 10 && y >= 5 && y <= 7) return true;

            // Правая перекладина (сверху)
            if (x >= 11 && x <= 12 && y >= 7 && y <= 8) return true;

            // Нижний центральный блок
            if (x >= 6 && x <= 10 && y >= 10 && y <= 13) return true;

            // Нижний правый блок
            if (x >= 11 && x <= 12 && y >= 10 && y <= 12) return true;

            return false;
        }
    }
}
