namespace Tyuiu.MedvedevaPI.Sprint4.Task7.V18;

using Tyuiu.MedvedevaPI.Sprint4.Task7.V18.Lib;

class Program
{
    static void Main(string[] args)
    {
        int n = 5;
        int m = 3;
        int[,] mtrx = new int[n, m];
        string str = "145258749635789";
        DataService ds = new DataService();
        Random rnd = new Random();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int index = 0;
        Console.WriteLine("\nМассив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;

            }
            Console.WriteLine();
        }
        
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(n,m,str);
        Console.WriteLine("произведение четных чисел =" + res);

        Console.ReadKey();
    }
}