using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShakirovSA.Sprint3.Task4.V8.Lib
{
    public class DataService : ISprint3Task4V8
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int i = startValue; i < stopValue; i++)
            {
                if (i == 0)
                {
                    break;
                }
                else
                {
                    res *= (i / Math.Sin(i)) + 0.5;
                }
            }
            return Math.Round(res, 3);

            }
        }
    }
