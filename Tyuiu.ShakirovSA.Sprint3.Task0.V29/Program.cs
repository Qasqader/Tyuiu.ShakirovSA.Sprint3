using Tyuiu.ShakirovSA.Sprint3.Task0.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double value = 0.55;
        int startValue = 1;
        int stopValue = 10;
        Console.WriteLine("Перменная x = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));

        Console.ReadKey();
    }
}