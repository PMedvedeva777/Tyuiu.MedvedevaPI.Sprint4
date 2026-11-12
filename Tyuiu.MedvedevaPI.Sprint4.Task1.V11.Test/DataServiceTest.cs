namespace Tyuiu.MedvedevaPI.Sprint4.Task1.V11.Test;

using Tyuiu.MedvedevaPI.Sprint4.Task1.V11.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCalc()
    {
        DataService ds = new DataService();
        int[] numsArray = { 2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1, 5, 3, 6, 6, 1, 6 };
        int res = ds.Calculate(numsArray);
        int wait = 32;
        Assert.AreEqual(wait, res);
    }
}
