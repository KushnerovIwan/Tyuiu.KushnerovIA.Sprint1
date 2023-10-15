using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint1.Task2.V17.Lib;

namespace Tyuiu.KushnerovIA.Sprint1.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertMinutesToHours()
        {
            DataService ds = new DataService();
            int value = 120;
            int res = ds.ConvertMinutesToHours(value);
            Assert.AreEqual(2, res);
        }
    }
}
