using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint1.Task6.V5.Lib;

namespace Tyuiu.KushnerovIA.Sprint1.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckSymmetricalWords()
        {
            DataService ds = new DataService();
            string value = "serres ereret werrew";
            var res = ds.CheckSymmetricalWords(value);
            Assert.AreEqual("serreswerrew", res);
        }
    }
}
