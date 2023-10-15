using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint1.Task4.V4.Lib;

namespace Tyuiu.KushnerovIA.Sprint1.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.75, res);

        }
    }
}
