using Tyuiu.AshirovaDA.Sprint2.Task2.V16.Lib;

namespace Tyuiu.AshirovaDA.Sprint2.Task2.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точки ВНУТРИ заштрихованной области
            Assert.IsTrue(ds.CheckDotInShadedArea(4, 6));    // левая палка
            Assert.IsTrue(ds.CheckDotInShadedArea(14, 8));   // правая палка
            Assert.IsTrue(ds.CheckDotInShadedArea(8, 6));    // левая перекладина
            Assert.IsTrue(ds.CheckDotInShadedArea(12, 7));   // правая перекладина
            Assert.IsTrue(ds.CheckDotInShadedArea(8, 11));   // нижний блок

            // Точки ВНЕ области
            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));    // верхний левый угол
            Assert.IsFalse(ds.CheckDotInShadedArea(8, 1));    // над фигурой
            Assert.IsFalse(ds.CheckDotInShadedArea(8, 9));    // «дырка» в букве Ч
            Assert.IsFalse(ds.CheckDotInShadedArea(15, 15));  // правый нижний угол

        }
    }
}
