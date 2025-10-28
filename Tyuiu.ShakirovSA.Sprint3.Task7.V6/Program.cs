using Tyuiu.ShakirovSA.Sprint3.Task7.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int startValue = -5;
        int stopValue = 5;
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);
        int len = ds.GetMassFunction(startValue, stopValue).Length;
        double[] values = new double [len];
        values = ds.GetMassFunction(startValue, stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("++---------+--------++");
        Console.WriteLine("||    X    |  f(x)  ||");
        Console.WriteLine("++---------+--------++");
        for (int i = 0; i < len-1; i++)
        {
            Console.WriteLine("|{0, 5:d}     |  {1,5:f2} ||", startValue, values[i]);
            startValue++;
        }
        Console.WriteLine("+---------+----------+");

        Console.ReadKey();
    }
}