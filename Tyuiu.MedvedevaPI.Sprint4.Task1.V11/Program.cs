namespace Tyuiu.MedvedevaPI.Sprint4.Task1.V11;

using Tyuiu.MedvedevaPI.Sprint4.Task1.V11.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[] numsArray = { 2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1, 5, 3, 6, 6, 1, 6 };
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i <= numsArray.Length - 1; i++)
        {
            Console.WriteLine(numsArray[i]);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Сумма четных эллементов массива:");
        int res = ds.Calculate(numsArray);
        Console.WriteLine(res);
        Console.WriteLine();
        Console.ReadKey();
    }
}