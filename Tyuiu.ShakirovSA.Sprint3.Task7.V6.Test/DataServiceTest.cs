using Tyuiu.ShakirovSA.Sprint3.Task7.V6.Lib;
namespace Tyuiu.ShakirovSA.Sprint3.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] wait = new double[11];
            wait[0] = 23.92;
            wait[1] = 18.88;
            wait[2] = 13.1;
            wait[3] = 7.24;
            wait[4] = 1.8;
            wait[5] = -8;
            wait[6] = -5.7;
            wait[7] = -11.26;
            wait[8] = -17.12;
            wait[9] = -22.88;
            wait[10] = -27.92;
            double[] res = ds.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(res, wait);
            
        }
    }
}
