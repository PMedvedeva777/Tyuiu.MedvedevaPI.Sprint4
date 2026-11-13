namespace Tyuiu.MedvedevaPI.Sprint4.Task6.V29.Test;
using Tyuiu.MedvedevaPI.Sprint4.Task6.V29.Lib;



[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCalc()
    {
        DataService ds = new DataService();
        var week = new string[] { "Весна", "Лето", "Осень", "Зима" };
        int res = ds.Calculate(week);
        int wait = 2;
        Assert.AreEqual(wait, res);
    }
}
