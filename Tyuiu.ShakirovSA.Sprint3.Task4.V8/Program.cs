using Tyuiu.ShakirovSA.Sprint3.Task4.V8.Lib;
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
        Console.WriteLine("Начало цикла = " + startValue);
        Console.WriteLine("Искомый символ = " + stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Результат = " + ds.Calculate(startValue, stopValue));

        Console.ReadKey();
    }
}