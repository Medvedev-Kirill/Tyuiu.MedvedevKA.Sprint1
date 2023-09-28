using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MedvedevKA.Sprint1.Task7.V12.Lib;

namespace Tyuiu.MedvedevKA.Sprint1.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double wait = 45;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
