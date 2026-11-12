namespace Tyuiu.MedvedevaPI.Sprint4.Task2.V15.Lib;

using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task2V15
{
    public int Calculate(int[] array)
    {
        int product = 0;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (array[i] % 2 == 0)
            {
                product = product + array[i];
            }

        }
        return product;
    }
}
