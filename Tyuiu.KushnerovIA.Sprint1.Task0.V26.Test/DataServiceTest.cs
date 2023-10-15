using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint1.Task0.V26.Lib;

namespace Tyuiu.KushnerovIA.Sprint1.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(7, ds.Calculate());

        }
    }
}