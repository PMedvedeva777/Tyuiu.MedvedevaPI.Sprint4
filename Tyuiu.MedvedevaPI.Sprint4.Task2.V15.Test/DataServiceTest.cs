using Tyuiu.MedvedevaPI.Sprint4.Task2.V15.Lib;

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
