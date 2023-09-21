using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MedvedevKA.Sprint1.Task3.V19.Lib;

namespace Tyuiu.MedvedevKA.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double y1 = 1;
            double x2 = 8;
            double y2 = 8;
            double wait = 8;
            var res = ds.ElephCanMove(x1, x2, y1, y2);
            Assert.AreEqual(wait, res);
            if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

    }
}
