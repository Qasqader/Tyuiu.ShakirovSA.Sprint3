using Tyuiu.ShakirovSA.Sprint3.Task1.V4.Lib;
namespace Tyuiu.ShakirovSA.Sprint3.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 10;
            double wait = 1.55;
            double res = ds.GetSumSeries(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
