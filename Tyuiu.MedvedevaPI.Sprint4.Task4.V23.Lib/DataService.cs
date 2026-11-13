namespace Tyuiu.MedvedevaPI.Sprint4.Task4.V23.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class DataService : ISprint4Task4V23
{
    public int Calculate(int[,] matrix)
    {
        int rows = matrix.GetUpperBound(0) + 1;
        int columns = matrix.Length / rows;
        int product = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i,j]%2!=0)
                {
                    product = product + matrix[i, j];
                }
            }
        }
        return product;
    }
}