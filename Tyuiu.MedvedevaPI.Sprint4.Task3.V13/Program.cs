namespace Tyuiu.MedvedevaPI.Sprint4.Task3.V13;

using Tyuiu.MedvedevaPI.Sprint4.Task3.V13.Lib;

class Program
{
    static void Main(string[] args)
    {
        int[,] mas2 = new int[5, 5]{ {4, 7, 4, 2, 1},
                                    {6, 7, 3, 6, 5},
                                    {6, 5, 3, 3, 5},
                                    {4, 4, 6, 4, 7},
                                    {2, 1, 2, 3, 4},};
        int rows = mas2.GetUpperBound(0) + 1;
        int columns = mas2.Length / rows;
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mas2[i, j]} \t");

            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(mas2);
        Console.WriteLine("сумма чисел 3 столбца =" + res);

        Console.ReadKey();
    }
}