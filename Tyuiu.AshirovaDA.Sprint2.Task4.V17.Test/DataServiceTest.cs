using Tyuiu.AshirovaDA.Sprint2.Task4.V17.Lib;


namespace Tyuiu.AshirovaDA.Sprint2.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 30;
            double y = 0;
            double res = ds.Calculate(x, y);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 5.12;
            Assert.AreEqual(wait, res);
        }
    }
}