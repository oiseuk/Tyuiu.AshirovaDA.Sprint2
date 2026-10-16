using Tyuiu.AshirovaDA.Sprint2.Task6.V8.Lib;

namespace Tyuiu.AshirovaDA.Sprint2.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay_Normal()
        {
            DataService ds = new DataService();
            string res = ds.FindDateOfPreviousDay(5, 15);
            Assert.AreEqual("14.05", res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay_FirstOfMarch()
        {
            DataService ds = new DataService();
            // 01.03 → 28.02 (не високосный год)
            string res = ds.FindDateOfPreviousDay(3, 1);
            Assert.AreEqual("28.02", res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay_FirstOfMay()
        {
            DataService ds = new DataService();
            // 01.05 → 30.04
            string res = ds.FindDateOfPreviousDay(5, 1);
            Assert.AreEqual("30.04", res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay_FirstOfFebruary()
        {
            DataService ds = new DataService();
            // 01.02 → 31.01
            string res = ds.FindDateOfPreviousDay(2, 1);
            Assert.AreEqual("31.01", res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay_FirstOfDecember()
        {
            DataService ds = new DataService();
            // 01.12 → 30.11
            string res = ds.FindDateOfPreviousDay(12, 1);
            Assert.AreEqual("30.11", res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay_InvalidMonth()
        {
            DataService ds = new DataService();
            Assert.ThrowsException<ArgumentException>(() => ds.FindDateOfPreviousDay(13, 1));
        }
    }
}