using Tyuiu.AshirovaDA.Sprint2.Task5.V11.Lib;

namespace Tyuiu.AshirovaDA.Sprint2.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay_Normal()
        {
            DataService ds = new DataService();
            string res = ds.FindDateOfNextDay(2024, 5, 15);
            Assert.AreEqual("16.05.2024", res);
        }

        [TestMethod]
        public void ValidFindDateOfNextDay_End31()
        {
            DataService ds = new DataService();
            string res = ds.FindDateOfNextDay(2024, 1, 31);
            Assert.AreEqual("01.02.2024", res);
        }

        [TestMethod]
        public void ValidFindDateOfNextDay_End30()
        {
            DataService ds = new DataService();
            string res = ds.FindDateOfNextDay(2024, 4, 30);
            Assert.AreEqual("01.05.2024", res);
        }

        [TestMethod]
        public void ValidFindDateOfNextDay_February()
        {
            DataService ds = new DataService();
            string res = ds.FindDateOfNextDay(2023, 2, 28);
            Assert.AreEqual("01.03.2023", res);
        }

        [TestMethod]
        public void ValidFindDateOfNextDay_EndOfYear()
        {
            DataService ds = new DataService();
            string res = ds.FindDateOfNextDay(2024, 12, 31);
            Assert.AreEqual("01.01.2025", res);
        }
    }
}