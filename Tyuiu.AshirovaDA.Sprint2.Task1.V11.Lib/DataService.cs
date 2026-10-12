using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AshirovaDA.Sprint2.Task1.V11.Lib
{
    public class DataService : ISprint2Task1V11
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == c) | (b == c);      // |  → False
            res[1] = (a == c) & (a < b);       // &  → False
            res[2] = (a < b) || (a == c);      // || → True
            res[3] = (a < b) && (a == c);      // && → False
            res[4] = !(a == c);                // !  → True
            res[5] = (a < b) ^ (a > c);        // ^  → False

            return res;
        }
    }
}
