namespace Tyuiu.MedvedevaPI.Sprint4.Task5.V14.Test;
using Tyuiu.MedvedevaPI.Sprint4.Task5.V14.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void Calculate()
    {
        DataService ds = new DataService();
        int[,] mas2 = new int[5, 5]{ {-3, 7, 5, -2, 7},
                                {0, 3, 3, 6, 4},
                                {4, 4, 5, 5, 4},
                                {3, 4, 7, 5, 3},
                                {6, -1, 3, 6, 7},};
        int res = ds.Calculate(mas2);
        int wait = 22;
        Assert.AreEqual(res, wait);
    }
}
