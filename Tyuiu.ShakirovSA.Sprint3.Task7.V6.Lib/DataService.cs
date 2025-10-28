using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShakirovSA.Sprint3.Task7.V6.Lib
{
    public class DataService : ISprint3Task7V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] values;
            int len = (stopValue - startValue) + 1;
            values = new double[len];
            int f = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                double y = Math.Round((3 * Math.Cos(i) / (4 * i - 0.5)) + Math.Sin(i) - 5 * i - 2, 2);
                values[f] = y;
                f++;
            }
            return values;
        }
    }
}
