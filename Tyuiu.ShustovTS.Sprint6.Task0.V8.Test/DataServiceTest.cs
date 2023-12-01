using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShustovTS.Sprint6.Task0.V8.Lib;

namespace Tyuiu.ShustovTS.Sprint6.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 1.741;
            Assert.AreEqual(wait, res);
        }
    }
}
