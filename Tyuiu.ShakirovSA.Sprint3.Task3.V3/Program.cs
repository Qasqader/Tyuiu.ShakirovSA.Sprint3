using Tyuiu.ShakirovSA.Sprint3.Task3.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    { 
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string value = "cvbmzff orffgtrr dkfvfffdr";
        char item = 'f';
        Console.WriteLine("Исходная строка = " + value);
        Console.WriteLine("Искомый символ = " + item);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Количество символов = " + ds.GetMinCharCount(value, item));

        Console.ReadKey();
    }
}
