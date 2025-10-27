using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShakirovSA.Sprint3.Task2.V21.Lib
{
    public class DataService : ISprint3Task2V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            int i = startValue;
            do
            {
                
                
                double term =  Math.Pow(1 / (Math.Sin(i) + 2 * Math.Pow (value, i)), i);
                sum += term;
                i++;
            }
            while(i <= stopValue);
            return Math.Round(sum, 3);
        }
    }
}
