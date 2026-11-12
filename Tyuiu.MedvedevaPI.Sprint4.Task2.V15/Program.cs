namespace Tyuiu.MedvedevaPI.Sprint4.Task2.V15;

using Tyuiu.MedvedevaPI.Sprint4.Task2.V15.Lib;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int len;
        Console.WriteLine("Введите количество элементов массива:");
        len = Convert.ToInt32(Console.ReadLine());
        int[] numsArray = new int[len];
        for (int i = 0; i <= len - 1; i++)
        {
            numsArray[i] = rnd.Next(2, 8);
        }
        Console.WriteLine("Массив:");
        for (int i = 0; i <= len - 1; i++)
        {
            
            Console.WriteLine(numsArray[i] + "\t");
        }
        Console.WriteLine();
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