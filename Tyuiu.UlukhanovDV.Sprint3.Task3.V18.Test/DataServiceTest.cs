using Tyuiu.UlukhanovDV.Sprint3.Task3.V18.Lib;
namespace Tyuiu.UlukhanovDV.Sprint3.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();
            string str = "4n5nvf 56 bgy";
            char item = 'n';
            string res = ds.ReplaceNumOnChar(str, item);
            string wait = "nnnnvf nn bgy";
            Assert.AreEqual(wait, res);
        }
    }
}
