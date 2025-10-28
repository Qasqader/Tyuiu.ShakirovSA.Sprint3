using Tyuiu.ShakirovSA.Sprint3.Task6.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int startValue = 14;
        int endValue = 20;
        Console.WriteLine("Начало отрезка = " + startValue);
        Console.WriteLine("Конец отрезка = " +  endValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Количество делителей = " + ds.GetSumTheDivisors(startValue, endValue));

        Console.ReadKey();
    }
}