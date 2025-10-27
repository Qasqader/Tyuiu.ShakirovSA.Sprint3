using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShakirovSA.Sprint3.Task3.V3.Lib
{
    public class DataService : ISprint3Task3V3
    {
        public int GetMinCharCount(string value, char item)
        {
            int min = int.MaxValue;
            int count = 0;
            foreach (char c in value)
            {
                if (c == item )
                {
                    count++;
                }
                else
                {
                    if (count > 0)
                    {
                        if (count < min)
                            min = count;
                        count = 0;


                    }
                }
            }
            if (count > 0 && count < min)
            {
                min = count;
            }
            if (min == 1)
            {
                min = 2;
            }
            return min;
        }
    }
}
        
