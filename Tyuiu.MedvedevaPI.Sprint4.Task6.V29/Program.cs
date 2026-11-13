namespace Tyuiu.MedvedevaPI.Sprint4.Task6.V29;

using Tyuiu.MedvedevaPI.Sprint4.Task6.V29.Lib;

class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        var week = new string[] { "Весна", "Лето", "Осень", "Зима" };
        Console.WriteLine("Исходный массив");
        for (int i = 0; i<=week.Length -1; i++)
        {
            Console.WriteLine(week[i]);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Количество элементов длинна которых > 4");

        int res = ds.Calculate(week);
        Console.WriteLine(res);

        Console.ReadKey();
    }
}