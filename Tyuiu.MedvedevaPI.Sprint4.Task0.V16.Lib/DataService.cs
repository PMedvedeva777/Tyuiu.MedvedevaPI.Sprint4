namespace Tyuiu.MedvedevaPI.Sprint4.Task0.V16.Lib;

using System.Net.Http.Headers;
using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task0V16
{
    public int GetMultEvenArrEl(int[] array)
    {
        int product = 1;
        for (int i = 0; i<=array.Length - 1; i++)
        {
            if (array[i]%2==0)
            {
                product = product * array[i];
            }
          
        }
        return product;
    }
}
