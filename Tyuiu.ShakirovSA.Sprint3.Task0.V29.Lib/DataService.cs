using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShakirovSA.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                sum += Math.Pow(value, Math.Pow(2, i)) + (1.0 / (i + 1));
            }
            sum = Math.Cos(value) * sum;
            return Math.Round(sum, 3);

        }
    }
}
