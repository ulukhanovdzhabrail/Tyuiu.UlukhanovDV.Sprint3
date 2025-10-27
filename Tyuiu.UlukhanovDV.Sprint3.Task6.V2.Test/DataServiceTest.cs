using Tyuiu.UlukhanovDV.Sprint3.Task6.V2.Lib;
namespace Tyuiu.UlukhanovDV.Sprint3.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 12;
            int stopValue = 18;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 29;               
            Assert.AreEqual(wait, res);
        }
    }
}
