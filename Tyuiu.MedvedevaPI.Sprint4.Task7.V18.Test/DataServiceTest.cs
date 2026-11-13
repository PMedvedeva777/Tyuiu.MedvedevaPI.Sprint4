namespace Tyuiu.MedvedevaPI.Sprint4.Task7.V18.Test;
using Tyuiu.MedvedevaPI.Sprint4.Task7.V18.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()
    {
        int rows = 5;
        int columns = 3;
        int[,] mtrx = new int[rows, columns];
        string str = "145258749635789";
        DataService ds = new DataService();
        int res = ds.Calculate(rows, columns, str);
        int wait = 12288;
        Assert.AreEqual(wait, res);
    }
}
