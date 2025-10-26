using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShakirovSA.Sprint3.Task1.V4.Lib
{
    public class DataService : ISprint3Task1V4
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            double k = 1;
            while (startValue <= 10)
            {
                sum += (1 / k) * (1 / k);
                k++;
                startValue ++;
            }
            return Math.Round(sum, 3);
        }
    }
}
