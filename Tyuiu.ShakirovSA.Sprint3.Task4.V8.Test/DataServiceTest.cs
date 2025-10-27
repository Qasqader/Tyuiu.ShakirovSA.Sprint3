using Tyuiu.ShakirovSA.Sprint3.Task4.V8.Lib;
namespace Tyuiu.ShakirovSA.Sprint3.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = -5;
            int y = 5;
            double wait = 2237.227;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
