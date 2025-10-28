using Tyuiu.ShakirovSA.Sprint3.Task6.V4.Lib;
namespace Tyuiu.ShakirovSA.Sprint3.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int wait = 8;
            int res = ds.GetSumTheDivisors(14, 20);
            Assert.AreEqual(wait, res);
        }
    }
}
