using Tyuiu.ShakirovSA.Sprint3.Task3.V3.Lib;
namespace Tyuiu.ShakirovSA.Sprint3.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string x = "cvbmzff orffgtrr dkfvfffdr";
            int wait = 1;
            char item = 'f';
            DataService ds = new DataService();
            int res = ds.GetMinCharCount(x, item);
            Assert.AreEqual(wait, res);
        }
    }
}
