namespace Tyuiu.MedvedevaPI.Sprint4.Task5.V14;

using Tyuiu.MedvedevaPI.Sprint4.Task5.V14.Lib;

class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();
        Random rnd = new Random();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите количество строк в массиве:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов в массиве:");
        int columns = Convert.ToInt32(Console.ReadLine());
        int[,] mtrx = new int[rows, columns];
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                mtrx[i, j] = rnd.Next(-5,8);

            }

        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");

            }
            Console.WriteLine();
        }
        Console.WriteLine("\nМассив");
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(mtrx);
        Console.WriteLine("количество положительных чисел =" + res);

        Console.ReadKey();
    }
}