using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShakirovSA.Sprint3.Task6.V4.Lib
{
    public class DataService : ISprint3Task6V4
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int x = startValue; x <= stopValue; x++) {
                for (int y = 1; y <= x; y++)
                {
                    if (x % y == 0)
                    {
                        if (y > 9)
                        {
                            sum++;
                        }
                    }
                }
            }
            return sum;
        }
    }
}
