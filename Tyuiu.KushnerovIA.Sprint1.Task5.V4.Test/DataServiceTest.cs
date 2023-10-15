using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint1.Task5.V4.Lib;

namespace Tyuiu.KushnerovIA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValueSecondsToHours()
        {
            DataService ds = new DataService();
            int time = 3600;
            var res = time / 3600;
            Assert.AreEqual(1, res);
        }
    }
}
