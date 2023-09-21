using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.MedvedevKA.Sprint1.Task1.V24.Lib;

namespace Tyuiu.MedvedevKA.Sprint1.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VallidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0, res);
        }
    }
}
