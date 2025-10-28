using Tyuiu.ShakirovSA.Sprint3.Task5.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int value = 2;
        int startValue1 = 1;
        int stopValue1 = 3;
        int startValue2 = 1;
        int stopValue2 = 6;
        Console.WriteLine("Перменная x = " + value);
        Console.WriteLine("Старт шага1 = " + startValue1);
        Console.WriteLine("Старт шага2 = " + startValue2);
        Console.WriteLine("Конец шага1 = " + stopValue1);
        Console.WriteLine("Конец шага2 = " + stopValue2);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(value, startValue1, startValue2, stopValue1, stopValue2));

        Console.ReadKey();
    }
}
