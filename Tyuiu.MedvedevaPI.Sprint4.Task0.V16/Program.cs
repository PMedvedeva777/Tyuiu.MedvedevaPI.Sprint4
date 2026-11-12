namespace Tyuiu.MedvedevaPI.Sprint4.Task0.V16;

using Tyuiu.MedvedevaPI.Sprint4.Task0.V16.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[] numsArray = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
        Console.WriteLine("Исходный массив:");
        for (int i = 0;i<=numsArray.Length-1;i++)
        {
            Console.WriteLine(numsArray[i]);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Произведение четных эллементов массива:");
        int res = ds.GetMultEvenArrEl(numsArray);
        Console.WriteLine(res);
        Console.WriteLine();
        Console.ReadKey();
    }
}