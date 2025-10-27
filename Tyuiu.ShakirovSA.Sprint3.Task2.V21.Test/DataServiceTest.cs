using Tyuiu.ShakirovSA.Sprint3.Task2.V21.Lib;
namespace Tyuiu.ShakirovSA.Sprint3.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.5;
            int y = 1;
            int z = 10;
            double wait = 0.298;
            double res = ds.GetSumSeries(x, y, z);
            Assert.AreEqual(wait,res);
        }
    }
}