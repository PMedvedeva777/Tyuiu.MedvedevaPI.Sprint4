namespace Tyuiu.MedvedevaPI.Sprint4.Task3.V13.Test;
using Tyuiu.MedvedevaPI.Sprint4.Task3.V13.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()
    {
        DataService ds = new DataService();
        int[,] mas2 = new int[5, 5]{ {4, 7, 4, 2, 1},
                                    {6, 7, 3, 6, 5},
                                    {6, 5, 3, 3, 5},
                                    {4, 4, 6, 4, 7},
                                    {2, 1, 2, 3, 4},};
        int res = ds.Calculate(mas2);
        int wait = 18;
        Assert.AreEqual(res, wait);
    }
}
