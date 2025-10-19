using Tyuiu.ShakirovSA.Sprint3.Task0.V29.Lib;
namespace Tyuiu.ShakirovSA.Sprint3.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 2.05;
            Assert.AreEqual(wait,res);
        }
    }
}
