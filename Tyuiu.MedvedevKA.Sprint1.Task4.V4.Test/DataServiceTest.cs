using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MedvedevKA.Sprint1.Task4.V4.Lib;

namespace Tyuiu.MedvedevKA.Sprint1.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 1;
            double wait = 0.875;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
