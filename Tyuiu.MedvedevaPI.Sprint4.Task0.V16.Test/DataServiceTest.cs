namespace Tyuiu.MedvedevaPI.Sprint4.Task0.V16.Test;

using Tyuiu.MedvedevaPI.Sprint4.Task0.V16.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidGetMultEvenArrEl()
    {
        DataService ds = new DataService();
        int[] numsArray = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
        int res = ds.GetMultEvenArrEl(numsArray);
        int wait = 3072;
        Assert.AreEqual(wait, res);

    }
}
