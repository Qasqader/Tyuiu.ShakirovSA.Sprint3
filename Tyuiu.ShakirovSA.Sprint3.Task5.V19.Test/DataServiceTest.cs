using Tyuiu.ShakirovSA.Sprint3.Task5.V19.Lib;
namespace Tyuiu.ShakirovSA.Sprint3.Task5.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(2, 1, 1, 3, 6);
            double wait = 30598.002;
            Assert.AreEqual(res, wait);
        }
    }
}
