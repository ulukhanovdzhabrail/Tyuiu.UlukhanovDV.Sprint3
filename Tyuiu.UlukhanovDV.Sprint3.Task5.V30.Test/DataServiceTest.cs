﻿using Tyuiu.UlukhanovDV.Sprint3.Task5.V30.Lib;
namespace Tyuiu.UlukhanovDV.Sprint3.Task5.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 11;
            double res = ds.GetSumSumSeries(x, startValue1,  startValue2, stopValue1, stopValue2);
            double wait = 132;
            Assert.AreEqual(wait, res);
        }
    }
}
