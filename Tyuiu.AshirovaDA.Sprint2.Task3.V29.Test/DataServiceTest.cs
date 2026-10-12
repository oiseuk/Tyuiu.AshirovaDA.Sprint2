using Tyuiu.AshirovaDA.Sprint2.Task3.V29.Lib;

namespace Tyuiu.AshirovaDA.Sprint2.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate_Branch1_xGreaterThan1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            Assert.AreEqual(96, res);
        }

        [TestMethod]
        public void ValidCalculate_Branch2_xEquals0()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(0);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void ValidCalculate_Branch3_Between()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(0.5);
            Assert.AreEqual(2.236, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculate_Branch4_xLessThanMinus33()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-40);
            Assert.AreEqual(-439.975, res, 0.001);
        }
    }
}