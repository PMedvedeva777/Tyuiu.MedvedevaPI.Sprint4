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
        int len;
        Console.WriteLine("Введите количество элементов массива:");
        len = Convert.ToInt32(Console.ReadLine());
        int[] numsArray = new int[len];
        for (int i = 0; i <= numsArray.Length - 1; i++)
        {
            Console.WriteLine("Введите значение" + i + "элемента массива:");
            numsArray[i] = Convert.ToInt32(Console.ReadLine());
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